using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAlgo.Shared.Models
{
    public class AlgorithmStep
    {
        public String Summary { get; set; }
        public List<AlgorithmStepLink> NextSteps { get; set; }
        public Boolean HasNextSteps
        {
            get
            {
                return NextSteps != null && NextSteps.Count > 0;
            }
        }
    }
}
