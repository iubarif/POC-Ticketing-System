using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using POC.TicketSystem.Web.Models;
using Newtonsoft.Json;
using System.IO;

namespace POC.TicketSystem.Web
{
    public static class StaticDataService
    {
        public static StaticData GetStaticData()
        {            
            string jsonPath = string.Format(@"{0}{1}\{2}", AppDomain.CurrentDomain.BaseDirectory, "StaticData", "StaticData.json");


            var jsonObject = JsonConvert.DeserializeObject<StaticData>(File.ReadAllText(jsonPath));

            return jsonObject;
        }
    }
}