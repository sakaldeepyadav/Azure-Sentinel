﻿using Microsoft.Azure.Sentinel.KustoServices.Contract;
using Microsoft.Azure.Sentinel.KustoServices.Implementation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YamlDotNet.Serialization;

namespace Kqlvalidations.Tests.FunctionSchemasLoaders
{
    public static class ParsersDatabase
    {
        public static List<ParserConfiguration> Parsers => new List<ParserConfiguration>()
            {
                new ParserConfiguration()
                {
                    Schema= "ASimDns",
                    SampleFunctionName= "_Im_Dns",
                },
                new ParserConfiguration()
                {
                    Schema= "ASimWebSession",
                    SampleFunctionName= "_Im_WebSession",
                },
                new ParserConfiguration()
                {
                    Schema= "ASimNetworkSession",
                    SampleFunctionName= "_Im_NetworkSession",
                },
            };
    }

    public class ParserConfiguration
    {
        /// <summary>
        /// The schema name
        /// </summary>
        public string Schema { get; set; }
        /// <summary>
        /// A sample function for this schema. Parser functions that use this schema duplicate the result columns from the sample function.
        /// </summary>
        public string SampleFunctionName { get; set; }
    }
}
