using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_Sharp_Study_Guide.Models.JsonApiCalls
{
    // New model created by copying from Postman and Paste Specialing as JSON. We can now access these API values by referencing these variables
    public class NpsJsonInfo
    {
        public string total { get; set; }
        public Datum[] data { get; set; }
        public string limit { get; set; }
        public string start { get; set; }
    }

    public class Datum
    {
        public string states { get; set; }
        public string latLong { get; set; }
        public string description { get; set; }
        public string designation { get; set; }
        public string parkCode { get; set; }
        public string id { get; set; }
        public string directionsInfo { get; set; }
        public string directionsUrl { get; set; }
        public string fullName { get; set; }
        public string url { get; set; }
        public string weatherInfo { get; set; }
        public string name { get; set; }
    }
}