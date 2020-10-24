using GreenAlgo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenAlgo.Server.Services
{
    public class AlgorithmService
    {
        private Dictionary<Guid, Algorithm> algorithms = new Dictionary<Guid, Algorithm>();

        public AlgorithmService()
        {
            Algorithm alg1 = new Algorithm
            {
                Id = Guid.NewGuid(),
                Name = "Algorithm 1",
                Description = "This is the first algorithm.",
                FirstStep = new AlgorithmStep
                {
                    Summary = "Step 1.1"
                }
            };
            algorithms.Add(alg1.Id, alg1);
            Algorithm alg2 = new Algorithm
            {
                Id = Guid.NewGuid(),
                Name = "Algorithm 2",
                Description = "This is the second algorithm.",
                FirstStep = new AlgorithmStep
                {
                    Summary = "Step 2.1"
                }
            };
            algorithms.Add(alg2.Id, alg2);
        }
        public IEnumerable<Algorithm> Get()
        {
            return algorithms.Values.ToList();
        }
        public Algorithm Get(Guid id)
        {
            return algorithms.GetValueOrDefault(id, null);
        }
    }
}
