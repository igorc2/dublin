using Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class TickerService
    {
        static System.Net.Http.HttpClient client = new HttpClient();

        public async Task<Ticker> GetProductAsync(string path)
        {
            Ticker product = null;
            HttpResponseMessage response = await client.GetAsync("https://bittrex.com/api/v1.1/public/getticker?market=btc-mco");
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Ticker>();
            }
            return product;
        }
        
    }
}
