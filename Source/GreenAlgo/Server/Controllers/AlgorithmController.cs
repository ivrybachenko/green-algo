using GreenAlgo.Shared.Models;
using GreenAlgo.Server.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenAlgo.Server.Controllers
{
    [ApiController]
    [Route("algorithm")]
    public class AlgorithmController
    {
        private readonly ILogger<AlgorithmController> logger;
        private readonly AlgorithmService algorithmService;

        public AlgorithmController(ILogger<AlgorithmController> logger, AlgorithmService algorithmService)
        {
            this.logger = logger;
            this.algorithmService = algorithmService;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Algorithm> Get()
        {
            return algorithmService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Algorithm Get(Guid id)
        {
            return algorithmService.Get(id);
        }
    }
}
