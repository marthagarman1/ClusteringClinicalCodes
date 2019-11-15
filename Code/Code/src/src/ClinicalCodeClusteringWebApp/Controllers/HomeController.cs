using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Accord.Math;
using ClinicalCodeClusteringWebApp.Data;
using ClinicalCodeClusteringWebApp.Models;
using ClinicalCodeClusteringWebApp.Models.Algorithms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ClinicalCodeClusteringWebApp.Controllers
{
    /// <summary>
    /// Controls Application Logic
    /// </summary>
    public class HomeController : Controller
    {
        public static IConfigurationRoot Configuration;


        /// <summary>
        ///     Database connection.
        /// </summary>
        private readonly ApplicationDbContext _databaseconnection = new ApplicationDbContext();

        /// <summary>
        ///     Generates landing page.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///     Generates Claim Revenue Chart if user is logged in.
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Revenue()
        {
            return View();
        }

        /// <summary>
        ///     Generates reports page if user is logged in.
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Reports()
        {
            return View();
        }


        /// <summary>
        ///     Generates About Page.
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
           // XmlDocument documentation = new XmlDocument();
            //documentation.Load("ClinicalCodeClusteringWebApp.xml");
            //ViewData["Message"] = documentation.OuterXml;

            return View();
        }

        /// <summary>
        ///     Generates Privacy Policy.
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        ///     Uploads CSV file to database.
        ///     Then call K-Means Analysis.
        ///     Redirects to cluster graph.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "App_Data/uploads",
                file.Name);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            //Uses Model method to upload file to database
            var uploadToDB = new UploadToDb();
            uploadToDB.Upload(path);
            var dbUpload = new DownloadFromDB();

            //Returns x,y dataset of double[][] with dimensions reduced
            var data = dbUpload.ParseDatabase();

            /************************** IRIS TESTING ***************/
            /*var irisFile = "wwwroot/iris_test_data_unlabelled.csv";
            var lines = System.IO.File.ReadAllLines(irisFile);
            var iris = lines.Select(line => line.Split(',')).ToArray();
            var irisDoubles = new double[iris.Length][];
            for (var i = 0; i < iris.Length; i++)
            {
                irisDoubles[i] = new double[4] {0, 0, 0, 0};
                for (var j = 0; j < iris[i].Length; j++) irisDoubles[i][j] = double.Parse(iris[i][j]);
            }

            var data = dbUpload.ReduceDimensions(irisDoubles);*/
            /******************************************************/

            //var k = 4;
            var k = FindK(data);
            var kMeans = new RunKMeans(k, data);
            var membership = kMeans.Membership;
            var centroids = kMeans.Centroids;
            var iteration = kMeans.GetIterations();


            /*************************** LOG output for Testing **************************/
            var output = new string[membership.Length][];
            for (var i = 0; i < membership.Length; i++)
            {
                var tuple = new string[3];
                for (var j = 0; j < tuple.Length; j++)
                {
                    if (j < 2)
                        tuple[j] = data[i][j].ToString();
                    if (j == 2)
                        tuple[j] = membership[i].ToString();
                }

                output[i] = tuple;
            }

            System.IO.File.WriteAllLines(@"TESTOUTPUT.csv", output
                .Select(line => string.Join(",", line)));
            /*****************************************************************************/

            //Use TempData to hold for other controllers --future iterations replace with model
            TempData["data"] = JsonConvert.SerializeObject(data);
            TempData["centroids"] = JsonConvert.SerializeObject(centroids);
            TempData["series"] = JsonConvert.SerializeObject(membership);

            return RedirectToAction("Analytics", "Home");
        }

        /// <summary>
        ///     Takes in graph parameters, outputs scatter graph
        ///     and table of information, if user is logged in.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="centroids"></param>
        /// <param name="membership"></param>
        /// <returns></returns>
        [Authorize]
        public IActionResult Analytics(double[][] data, double[][] centroids, int[] membership)
        {

            var _data = TempData["data"] == null
                ? null
                : JsonConvert.DeserializeObject<double[][]>((string)TempData["data"]);
            var _centroids = TempData["centroids"] == null
                ? null
                : JsonConvert.DeserializeObject<double[][]>((string)TempData["centroids"]);
            var _membership = TempData["series"] == null
                ? null
                : JsonConvert.DeserializeObject<int[]>((string)TempData["series"]);


            ViewBag.ChartData = data.Length == 0 ? _data : data;
            ViewBag.ChartSeries = membership.Length == 0 ? _membership : membership;
            ViewBag.ChartCenters = centroids.Length == 0 ? _centroids : centroids;

            var cptCats = _databaseconnection.CptCats.ToList();
            return View(cptCats);
        }


        /// <summary>
        ///     Generates custom error: 404 page.
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public int FindK(double[][] dataset)
        {
            var distortion = new double[10];
            var k = 1;
            for (var i = 0; i < 10; i++)
            {
                var km = new RunKMeans(k, dataset);
                var distortion1 = km.Distortion();
                distortion[i] = distortion1;
                k++;
            }

            //roubust
            var drop = new double[distortion.Length - 1];
            //Find greatest drop 
            for (var i = 0; i < drop.Length; i++) drop[i] = Math.Abs(distortion[i] - distortion[i + 1]);

            //return the value of k at the lowest drop
            var biggestDrop = drop.IndexOf(drop.Max()) + 3;

            return biggestDrop;
        }

        /// <summary>
        /// In future iterations use the 
        /// </summary>
        /// <param name="dataset"></param>
        /// <returns></returns>
        /* public int FindK(double[][] dataset)
        {
            double[] CHResults = new double[10];
            
            for (int k = 2; k < 10; k++)
            {
                RunKMeans newRun = new RunKMeans(k, dataset);
                CHResults[k] = newRun.CHIndex();
            }

            return CHResults.IndexOf(CHResults.Max());
        }*/
    }
}