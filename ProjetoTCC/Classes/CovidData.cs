using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCC.Classes
{
    public class CovidData
    {
        [JsonProperty("data")]
        public Covid covid { get; set; }
    }

    public class Covid
    {
        [JsonProperty("country")]
        public String country { get; set; }

        [JsonProperty("confirmed")]
        public int confirmed { get; set; }

        [JsonProperty("deaths")]
        public int? deaths { get; set; }
    }
}
