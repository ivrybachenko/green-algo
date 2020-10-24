using System;

namespace GreenAlgo.Shared.Models
{
    public class Algorithm
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public AlgorithmStep FirstStep { get; set; }
    }
}
