using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalCodeClusteringWebApp.Models
{
    public class CPTCats
    {

        /// <summary>
        /// Primary Key identifying patient visit. 
        /// </summary>
        public string ClaimId { get; set; }

        /// <summary>
        /// Drug Assay Tests. 
        /// </summary>
        public string DrugAssay { get; set; }

        /// <summary>
        /// Microbiology Tests. 
        /// </summary>
        public string Microbiology { get; set; }

        /// <summary>
        /// Chemistry Tests. 
        /// </summary>
        public string Chemistry { get; set; }

        /// <summary>
        /// Disease Panels. 
        /// </summary>
        public string DiseasePanels { get; set; }

        /// <summary>
        /// Hematology Tests. 
        /// </summary>
        public string Hematology { get; set; }

        /// <summary>
        /// Immunology Tests. 
        /// </summary>
        public string Immunology { get; set; }

        /// <summary>
        /// Urinalysis Tests. 
        /// </summary>
        public string Urinalysis { get; set; }
    }
}
