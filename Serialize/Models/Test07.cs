﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize.Models
{
    public class Test07
    {
        [JsonProperty(Required = Required.Always)]
        public string A { get; set; }

        public string B { get; set; }

        public string C { get; set; }


        ////[JsonConstructor]
        //public Test07(string a, string b)
        //{
        //    A = a;
        //    B = b;
        //    C = a + b;
        //}

        ////[JsonConstructor]
        //public Test07(string a, string b, string c)
        //{
        //    A = a;
        //    B = b;
        //    C = c;
        //}


    }
}
