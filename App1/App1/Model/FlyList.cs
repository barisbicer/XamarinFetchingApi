using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Globalization;
using Newtonsoft.Json.Converters;

namespace App1.Model
{
    public class FlyList
    {
        [JsonProperty("pgt_id")]
        public long PgtId { get; set; }

        [JsonProperty("dmlsts")]
        public string Dmlsts { get; set; }

        [JsonProperty("newparkpos")]
        public string Newparkpos { get; set; }

        [JsonProperty("preparkpos")]
        public string Preparkpos { get; set; }

        [JsonProperty("rkgelcag")]
        public string Rkgelcag { get; set; }

        [JsonProperty("rkarv")]
        public string Rkarv { get; set; }

        [JsonProperty("rkarviata")]
        public string Rkarviata { get; set; }

        [JsonProperty("rkgelpltar")]
        public DateTimeOffset Rkgelpltar { get; set; }

        [JsonProperty("rkgelplsaat")]
        public DateTimeOffset Rkgelplsaat { get; set; }

        [JsonProperty("rktescil")]
        public string Rktescil { get; set; }

        [JsonProperty("rkgidcag")]
        public string Rkgidcag { get; set; }

        [JsonProperty("rkdprt")]
        public string Rkdprt { get; set; }

        [JsonProperty("rkdprtiata")]
        public string Rkdprtiata { get; set; }

        [JsonProperty("rkgidpltar")]
        public DateTimeOffset Rkgidpltar { get; set; }

        [JsonProperty("rkgidplsaat")]
        public DateTimeOffset Rkgidplsaat { get; set; }

        [JsonProperty("send")]
        public long Send { get; set; }

        [JsonProperty("delFly")]
        public long DelFly { get; set; }

    }
}
