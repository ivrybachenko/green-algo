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
    public class PingPongController
    {
        private readonly ILogger<AlgorithmController> logger;

        public PingPongController(ILogger<AlgorithmController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        [Route("ping")]
        public String Get()
        {
            return "pong";
        }

    }
}
