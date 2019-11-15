using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;


namespace ClinicalCodeClusteringWebApp.Models.Algorithms
{
    /// <summary>
    ///  Uploads File to Database. 
    /// </summary>
    public class UploadToDb
    {
        /// <summary>
        /// Needed for Database configuration. 
        /// </summary>
        public static IConfigurationRoot Configuration;


        /// <summary>
        ///  Uploads selected file to Claim table and generates
        ///  new aggregated table in CPT_Cats. 
        /// </summary>
        public void Upload(string csvPath)
        {
            //Transform into Datatable
            var dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5]
            {
                new DataColumn("Claim_ID", typeof(string)),
                new DataColumn("CPT", typeof(string)),
                new DataColumn("Charge_Amount", typeof(string)),
                new DataColumn("Payment_Amount", typeof(string)),
                new DataColumn("Date_of_Submission", typeof(string))
            });

            //Read file into object
            var csvData = File.ReadAllText(csvPath);

            foreach (var row in csvData.Split('\n'))
                if (!string.IsNullOrEmpty(row))
                {
                    dt.Rows.Add();
                    var i = 0; //leave ID null for table generation 
                    foreach (var cell in row.Split(','))
                    {
                        dt.Rows[dt.Rows.Count - 1][i] = cell; //added due to error
                        i++;
                    }
                }

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables();

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();

            var consString = Configuration["ConnectionStrings:DefaultConnection"];

            //take the data and inject into other database 
            var qs =
                "\nINSERT INTO[dbo].[CPT_Cats]"
                + " ([Claim_ID]"
                + ",[DrugAssay]\r\n           ,[Microbiology]\r\n           ,[Chemistry]\r\n           " +
                ",[DiseasePanels]\r\n           ,[Hematology]\r\n           ,[Immunology]\r\n           ,[Urinalysis])"
                + "\nSelect Claim_ID,"
                + "Count(case when CPT > 80150 AND CPT < 80377 then 1 end) as \"DrugAssay\","
                + "Count(case when CPT > 87003 AND CPT < 97999 then 1 end) as \"Microbiology\","
                + "Count(case when CPT > 82009 AND CPT < 84999 then 1 end) as \"Chemistry\","
                + "Count(case when CPT > 80047 AND CPT < 80081 then 1 end) as \"DiseasePanels\","
                + "Count(case when CPT > 85002 AND CPT < 85999 then 1 end) as \"Hematology\","
                + "Count(case when CPT > 86000 AND CPT < 86849 then 1 end) as \"Immunology\","
                + "Count(case when CPT > 81000 AND CPT < 81099 then 1 end) as \"Urinalysis\""
                + "\nfrom dbo.Claims "
                + "\nwhere Payment_Amount is not null "
                + "\ngroup by dbo.claims.Claim_ID";

            using (var con = new SqlConnection(consString))
            {
                con.Open();
                using (var sqlBulkCopy = new SqlBulkCopy(con))
                {
                    //Set the database table name.
                    try
                    {
                        sqlBulkCopy.DestinationTableName = "Claims";
                        sqlBulkCopy.WriteToServer(dt);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        
                        throw;
                    }
                   

                   
                }

                //Run Querey Command -- from StackOverflow
                var cmd = new SqlCommand(qs, con);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) Console.WriteLine("{0}, {1}", reader[0], reader[1]);
                    con.Close();
                }
            }
        }


    }
}