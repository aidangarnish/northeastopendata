using Newtonsoft.Json;
using NorthEastOpenData.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace NorthEastOpenData.Controllers
{   
    [RoutePrefix("library")]
    public class LibraryController : ApiController
    {
        [HttpGet]
        [Route("monthlyvisits")]
        public IEnumerable<LibraryMonthlyVisits> MonthlyVisits()
        {
            string directory = HttpContext.Current.Server.MapPath("..");
            var json = File.ReadAllText(directory +"\\Data\\librariesMonthlyVisits.json");

            IEnumerable<LibraryMonthlyVisits> monthlyVisits = JsonConvert.DeserializeObject<IEnumerable<LibraryMonthlyVisits>>(json);

            return monthlyVisits;
        }
    }
}
