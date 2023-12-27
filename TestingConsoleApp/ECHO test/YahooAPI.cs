using Flurl.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TestingConsoleApp.ECHO_test;
using YahooFinanceApi;

namespace TestingConsoleApp
{
    public static class YahooAPI
    {
        public static async Task<int> TestAsync()
        {
             var history = await Yahoo.GetHistoricalAsync("AAPL", new DateTime(2023, 11, 29), new DateTime(2023, 11, 30), Period.Daily);

            var securities = await Yahoo.Symbols("AAPL").QueryAsync();

            var aapl = securities["AAPL"].Fields;


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://yahoo-finance15.p.rapidapi.com/api/v1/markets/stock/modules?ticker=AAPL&module=asset-profile"),
                Headers =
                {
                    { "X-RapidAPI-Key", "7abe6aa6aamsh4b519235bbcb971p138580jsnbd6c1ec9d677" },
                    { "X-RapidAPI-Host", "yahoo-finance15.p.rapidapi.com" },
                },
            };

            Root root = new Root();

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync();

                root = JsonConvert.DeserializeObject<Root>(jsonString);

            }

            ReturnModel returnModel = new ReturnModel()
            {
                fullCompanyName =      aapl["LongName"],
                marcetCap =            aapl["MarketCap"],
                yearFounded =          aapl["LongName"],
                numberOfEmployees =    root.body.fullTimeEmployees,
                headquartersCity =     root.body.city,
                headquartersCountry =  root.body.country,
                date =                 DateTime.Now,
                closePrice = history[0].Close.ToString(),
                openPrice = history[0].Open.ToString()
            };


            return 1;
        }
    }
    
    public class ReturnModel 
    {
        public string fullCompanyName { get; set; }
        public long marcetCap { get; set; }
        public string yearFounded { get; set; }
        public int numberOfEmployees { get; set; }
        public string headquartersCity { get; set; }
        public string headquartersCountry { get; set; }
        public DateTime date { get; set; }
        public string closePrice { get; set; }
        public string openPrice { get; set; }

    }

}
