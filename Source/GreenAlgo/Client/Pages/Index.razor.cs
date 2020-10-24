using GreenAlgo.Client.Services;
using GreenAlgo.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GreenAlgo.Client.Pages
{
    public partial class Index
    {
        [Inject]
        public AlgorithmService algorithmService { get; set; }
        private IEnumerable<Algorithm> algorithms;
        protected override async Task OnInitializedAsync()
        {
            await Refresh();
        }
        protected async Task Refresh()
        {
            algorithms = await algorithmService.Get();
        }
    }
}
