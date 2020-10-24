using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenAlgo.Client.Pages
{
    public partial class Create
    {
        private FormModel Model { get; set; } = new FormModel
        {
            Text = "Paste XML here"
        };
        private class FormModel
        {
            public String Text { get; set; }
        }

    }
}
