using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalCodeClusteringWebApp.Models
{
    /// <summary>
    /// Claim Table containing uploaded data. 
    /// </summary>
    public class Claims : IEnumerable
    {
        /// <summary>
        /// ClaimID, every claim can have multiple CPT codes. 
        /// </summary>
        public string ClaimId { get; set; }
        /// <summary>
        /// CPT Codes, there can be multiple Cpt codes on each claim. 
        /// </summary>
        public string Cpt { get; set; }
        /// <summary>
        /// Amount charged for test. 
        /// </summary>
        public decimal ChargeAmount { get; set; }
        /// <summary>
        /// Amount if any paid by insurance. 
        /// </summary>
        public decimal PaymentAmount { get; set; }
        /// <summary>
        /// Date claim was submitted. 
        /// </summary>
        public string DateOfSubmission { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }



}
