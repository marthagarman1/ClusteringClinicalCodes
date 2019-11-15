using System;
using System.Linq;
using Accord.Math;

namespace ClinicalCodeClusteringWebApp.Models.Algorithms
{
    /// <summary>
    ///     Runs the K-Means Algorithms on dataset.
    /// </summary>
    public class RunKMeans
    {
        /// <summary>
        ///     Count the number of times the K-Means
        ///     loop runs.
        /// </summary>
        private static int _iterations;

        /// <summary>
        ///     XY coordinates of _dataset.
        /// </summary>
        private readonly double[][] _dataset;

        /// <summary>
        ///     The number of clusters to find.
        /// </summary>
        private readonly int _k;

        /// <summary>
        ///     Returns coordinates of centroids.
        /// </summary>
        public readonly double[][] Centroids;


        /// <summary>
        ///     Goal of this program is to return membership variable.
        /// </summary>
        public readonly int[] Membership;

        /// <summary>
        ///     Measurment of total within cluster sum of squared error.
        /// </summary>
        private double _distortionScore;

        /// <summary>
        ///     Not used, future iteration with CH Index.
        /// </summary>
        private double tss;

        /// <summary>
        ///     Controller.
        ///     Takes in dataset and intializes variables.
        /// </summary>
        /// <param name="k">number of clusters</param>
        /// <param name="dataset">xy coordinates of data</param>
        public RunKMeans(int k, double[][] dataset)
        {
            //Step 1: Initialize variables
            _k = k;
            _dataset = dataset;
            Membership = new int[dataset.Length];
            Membership.Initialize();
            Centroids = new double[k][];
            for (var i = 0; i < k; i++) Centroids[i] = new[] {0.0, 0};

            //Step 2: Randomly Assign Centroid Means
            InitializeCentroidMeans(k);

            //Step 3: Enter KMeans Loop
            KMeans();
        }

        /// <summary>
        ///     Controls the K-Means loop.
        /// </summary>
        public void KMeans()
        {
            bool membershipChange;
            do
            {
                membershipChange = UpdateMembership();
                FindCentroidMeans();


                ++_iterations;
            } while (membershipChange);

            for (var i = 0; i < _dataset.Length; i++) Console.WriteLine(_dataset[i] + " " + Membership[i]);
        }


        /// <summary>
        /// Returns the number of times the loop needed to run
        /// to cluster. 
        /// </summary>
        /// <returns></returns>
        public int GetIterations()
        {
            return _iterations;

        }

        /// <summary>
        ///     Randomly assign mean to centroids by assigning to random centroid
        /// </summary>
        /// <param name="k"></param>
        public void InitializeCentroidMeans(int k)
        {
            // double[][] oldCentroidMeans = new double[Centroids.Length][];
            var tempData = _dataset;
            for (var i = 0; i < k; i++)
            {
                var oldCentroidMeans = Centroids.Copy();
                // Centroids.CopyTo(oldCentroidMeans);

                //Random Number between 0 and length of dataset
                var random = new Random();
                var randomnumber = random.Next(tempData.Length);

                //Assignment
                for (var j = 0; j < _dataset[0].Length; j++)
                    //sometimes datapoints are the same, removing from array doesn't work 
                    Centroids[i][j] = tempData[randomnumber][j];

                //if newly created centroid matches any old centroid, try again TESTING
                if (oldCentroidMeans.Any(t => Centroids[i].Intersect(t).Any())) --i;


                //Prevent the same tuple from being used --Using Linq
                tempData = tempData.Where((el, x) => x != randomnumber).ToArray();
            }
        }


        /* /// <summary>
         ///     Randomly assign mean to centroids by assigning to random centroid
         /// </summary>
         /// <param name="k"></param>
         public void InitializeCentroidMeans(int k)
         {
             var min = _dataset.Min(0);
             var max = _dataset.Max(0);
 
             for (var i = 0; i < k; i++)
             {
 
                 //Random Number between 0 and length of dataset
                 var random = new Random();
                // double[] newCentroid = new double[2];
 
                double newX = random.NextDouble() * (max[0] - min[0]) + min[0];
                double newY = random.NextDouble() * (max[1] - min[1]) + min[1];
                double[] insert = new[] {newX, newY};
                double[][] newCentroid = {insert};
                
                
                 //Assignment
                 for (var j = 0; j < _dataset[0].Length; j++)
                 { 
                     Centroids[i][j] = newCentroid[0][j];
 
                 }
 
             }
         }*/

        //Alternative method tested for implementing arrays
        private bool MatchArrays(double[] input, double[] target)
        {
            if (input.Length != target.Length) return false;

            for (var i = 0; i < input.Length; i++)
                if (Math.Abs(input[i] - target[i]) > 0.1)
                    return false;

            return true;
        }


        /// <summary>
        ///     Assigns membership to closest centroid
        /// </summary>
        /// <returns> returns true if any points change membership </returns>
        public bool UpdateMembership()
        {
            var change = false;
            foreach (var dataum in _dataset)
            {
                var previousMembership = Membership[_dataset.IndexOf(dataum)];
                var distance = new double[_k];
                for (var i = 0; i < _k; i++) distance[i] = Distance(dataum, Centroids[i]);

                Membership[_dataset.IndexOf(dataum)] = distance.IndexOf(distance.Min());
                if (previousMembership != Membership[_dataset.IndexOf(dataum)])
                    change = true;
            }

            return change;
        }


        /// <summary>
        ///     Total Variance Within Clusters Sum of Squares
        /// </summary>
        /// <param name="k"></param>
        /// <returns> returns distortion calculation. </returns>
        public double Distortion()
        {
            //CH Index needs center of graph -- not used
            //var totalCenter = FindTotalCenter();

            for (var i = 0; i < _k; i++)
            {
                var center = Centroids[i];
                for (var j = 0; j < _dataset.GetLength(0); j++)
                    //Below is used for CH Index
                    //tss += Distance(dataset[j], totalCenter);
                    if (Membership[j] == i)
                        _distortionScore += Distance(_dataset[j], center);
            }

            return _distortionScore;
        }


        /// <summary>
        ///     Calculates centroid means
        ///     sum of all associated datapoints / number of datapoints.
        /// </summary>
        /// <returns>Returns true if centroids are not empty</returns>
        private bool FindCentroidMeans()
        {
            var change = false;

            for (var c = 0; c < Centroids.Length; c++)
            {
                var sumDataX = 0.0;
                var sumDataY = 0.0;
                var numDatapoints = 0;
                //Find all datapoints belonging to Mean
                for (var i = 0; i < _dataset.Length; i++)
                    if (Membership[i] == Centroids.IndexOf(Centroids[c]))
                    {
                        sumDataX += _dataset[i][0];
                        sumDataY += _dataset[i][1];
                        ++numDatapoints;
                    }

                var xMean = sumDataX / numDatapoints;
                var yMean = sumDataY / numDatapoints;
                double[] newMean = {xMean, yMean};
                if (Centroids[c] != newMean)
                    change = true;

                Centroids[c] = newMean;

                //Check if any centroids are emtpy
                foreach (var centroid in Centroids)
                    if (centroid == null)
                        return false;
            }

            return change;
        }


        /// <summary>
        ///     Euclidean Distance between two points.
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="centroid"></param>
        /// <returns>returns sum of squared difference</returns>
        private static double Distance(double[] point1, double[] centroid)
        {
            var x1 = point1[0];
            var y1 = point1[1];
            var x2 = centroid[0];
            var y2 = centroid[1];

            var distance = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);

            return Math.Sqrt(distance);
        }


        /*Calinski-Harabasz Index - to be used in future iteration
         public double CHIndex()
        {
            
            TotalSumofSquares(); 
            var totalSumSquares = tss;
            var withinClustVar = twss;


            var betweenClusVar = totalSumSquares-withinClustVar;
            
            var result = (betweenClusVar / withinClustVar) * (dataset.Length - k) / (k - 1);

            return result;
        }

*/


        /* USED IN CHINDEX - NEXT ITERATION
               public double[] FindTotalCenter()
               {
                   double[] center = new[] {0.0, 0};
                   double totalX = 0;
                   double totalY = 0;

                   foreach (var point in dataset)
                   {
                       totalX += point[0];
                       totalY += point[1];
                   }

                   totalX /= dataset.Length;
                   totalY /= dataset.Length;

                   center[0] = totalX;
                   center[1] = totalY;
                   return center; 
               }
       */
    }
}