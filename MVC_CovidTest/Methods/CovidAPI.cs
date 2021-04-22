using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using MVC_CovidTest.Models;
using Newtonsoft.Json.Linq;

namespace MVC_CovidTest.Methods
{
    public static class CovidAPI
    {
        public static async Task<JsonRegions> getRegion()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://covid-19-statistics.p.rapidapi.com/regions"),
                Headers =
                    {
                        { "x-rapidapi-key", "1b70fb959dmsh9f1b1131f7abdecp1eb3a2jsne8c1b7266ac5" },
                        { "x-rapidapi-host", "covid-19-statistics.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(body);
                JsonRegions resultRegions = json.ToObject<JsonRegions>();

                return resultRegions;
            }
        }

        public static async Task<JsonProvinces> getProvinces(string iso)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://covid-19-statistics.p.rapidapi.com/provinces?iso={iso}"),
                Headers =
                    {
                        { "x-rapidapi-key", "1b70fb959dmsh9f1b1131f7abdecp1eb3a2jsne8c1b7266ac5" },
                        { "x-rapidapi-host", "covid-19-statistics.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(body);
                JsonProvinces resultProvinces = json.ToObject<JsonProvinces>();

                return resultProvinces;
            }
        }

        public static async Task<JsonReports> getReports()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://covid-19-statistics.p.rapidapi.com/reports"),
                Headers =
                    {
                        { "x-rapidapi-key", "1b70fb959dmsh9f1b1131f7abdecp1eb3a2jsne8c1b7266ac5" },
                        { "x-rapidapi-host", "covid-19-statistics.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(body);
                JsonReports resultReports = json.ToObject<JsonReports>();

                return resultReports;
            }
        }

        public static async Task<JsonReports> getReportsByRegion(string region)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://covid-19-statistics.p.rapidapi.com/reports?iso={region}"),
                Headers =
                    {
                        { "x-rapidapi-key", "1b70fb959dmsh9f1b1131f7abdecp1eb3a2jsne8c1b7266ac5" },
                        { "x-rapidapi-host", "covid-19-statistics.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(body);
                JsonReports resultReports = json.ToObject<JsonReports>();

                return resultReports;
            }
        }

        public static async Task<JsonReports> getReportsByProvince(string province)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://covid-19-statistics.p.rapidapi.com/reports?iso={province}"),
                Headers =
                    {
                        { "x-rapidapi-key", "1b70fb959dmsh9f1b1131f7abdecp1eb3a2jsne8c1b7266ac5" },
                        { "x-rapidapi-host", "covid-19-statistics.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(body);
                JsonReports resultReports = json.ToObject<JsonReports>();

                return resultReports;
            }
        }
    }
}