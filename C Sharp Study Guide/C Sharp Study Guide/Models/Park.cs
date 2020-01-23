using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace C_Sharp_Study_Guide.Models
{
    public class Park
    {
        [Key] // If you get red, add the using directive to the top ^^ using System.ComponentModel.DataAnnotations;
        public int ParkId { get; set; }

        // The remainder of the properties have the [Display(Name = "")] for labeling purposes, otherwise, the label will display as the variable name Ex: ParkName
        [Display(Name = "Park Name")]
        public string ParkName { get; set; }

        [Display(Name ="State")]
        public string ParkState { get; set; }

        [Display(Name = "Latitude")]
        public string ParkLat { get; set; }

        [Display(Name = "Longitude")]
        public string ParkLng { get; set; }

        [Display(Name = "Description")]
        public string ParkDescription { get; set; }

        [Display(Name = "Park Code")]
        public string ParkCode { get; set; }
    }
}