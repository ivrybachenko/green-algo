using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAlgo.Shared.Models
{
    public class AlgorithmStepLink
    {
        public AlgorithmStepLink PreviousStep { get; set; }
        public AlgorithmStepLink NextStep { get; set; }
        public String Condition { get; set; } = null;
    }
}
