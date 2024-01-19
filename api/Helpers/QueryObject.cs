using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Microsoft.Net.Http.Headers;

namespace api.Helpers
{
    public class QueryObject
    {
        public string? Symbol {get; set; } = null;
        public string? CompanyName { get; set; } = null;
    }
}