using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupUp.Models;

namespace GroupUp.Models.ViewModels
{
    public class RequestIndexViewModel
    {
        public Request Request { get; set; }

        public string ReturnUrl { get; set; }
    }
}
