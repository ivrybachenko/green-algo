using GreenAlgo.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GreenAlgo.Client.Services
{
    public class AlgorithmService
    {
        private HttpClient httpClient { get; set; }
        public AlgorithmService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Algorithm>> Get()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Algorithm>>("algorithm");
        }
        public async Task<Algorithm> Get(Guid id)
        {
            return await httpClient.GetFromJsonAsync<Algorithm>($"algorithm/{id}");
        }
    }
}
