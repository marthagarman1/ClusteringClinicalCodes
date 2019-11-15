using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Accord.Math;
using Accord.Statistics.Analysis;
using Microsoft.Extensions.Configuration;

namespace ClinicalCodeClusteringWebApp.Models.Algorithms
{
    /// <summary>
    /// Pulls from CPTCats table in database to reduce
    /// dimensions and return XY 2-dimensional table. 
    /// </summary>
    public class DownloadFromDB
    {
        //Needed for Configuration Builder
        public static IConfigurationRoot Configuration;


        //TODO reduce code resue - make own class
        //DB Connection Method
        private string DBConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables();

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
            var connectionstring = Configuration["ConnectionString"];

            var consString = Configuration["ConnectionStrings:DefaultConnection"];

            return consString;
        }

        /// <summary>
        /// Parses data to Database
        /// </summary>
        /// <returns> Returns jagged array from datatable</returns>
        public double[][] ParseDatabase()
        {
            var SqlCommand =
                "select* into TempTable\r\nfrom CPT_Cats\r\nAlter Table TempTable\r\ndrop column Claim_ID" +
                "\r\nSelect * from TempTable\r\nDrop Table TempTable";
            try
            {
                using (var con = new SqlConnection(DBConnection()))
                {
                    con.Open();
                    var readCommand = new SqlCommand(SqlCommand, con);
                    var sqlData = readCommand.ExecuteReader();

                    Console.Write(sqlData.Depth + sqlData.Depth);
                    var dt = new DataTable();
                    dt.Load(sqlData);

                    //ToArray is obsolete
                    var tableArray = dt.ToArray();

                    con.Close();
                    return ReduceDimensions(tableArray);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Reduces dimensions from database using Accord. 
        /// </summary>
        /// <param name="data"></param>
        /// <returns> XY coordinates</returns>
        public double[][] ReduceDimensions(double[][] dataset)
        {
            var pcaCenter = PrincipalComponentMethod.Center;
            var pca = new PrincipalComponentAnalysis(pcaCenter);
            pca.Learn(dataset);
            //2-Dimensional output, can change to 3 later
            pca.NumberOfOutputs = 2;
            var xyData = pca.Transform(dataset);
            return xyData;
        }
    }
}