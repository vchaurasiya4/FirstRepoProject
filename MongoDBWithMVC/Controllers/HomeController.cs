using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
using MongoDB.Driver.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace MongoDBWithMVC.Controllers
{
    public class HomeController : Controller
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;



        public ActionResult Index()
        {
            int i = 100;

            // Creates a CultureInfo for English in Belize.
            CultureInfo bz = new CultureInfo("en-BZ");
            // Displays i formatted as currency for the bz.
            var test = i.ToString("c", bz);

            // Creates a CultureInfo for English in the U.S.
            CultureInfo us = new CultureInfo("en-US");
            // Display i formatted as currency for us.
            var test1 = i.ToString("c", us);

            // Creates a CultureInfo for Danish in Denmark.
            CultureInfo dk = new CultureInfo("da-DK");
            // Displays i formatted as currency for dk.
            var test2 = i.ToString("c", dk);

            string s = "2342314854";

            NumberFormatInfo nfi = CultureInfo.CreateSpecificCulture("da-DK").NumberFormat;
            nfi = (NumberFormatInfo)nfi.Clone();

            string s1 = string.Format(nfi, "{0:C}", Double.Parse(s));

            return View();
        }


    }
}