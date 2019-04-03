using PluralSightMVC_App.Models;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;

namespace PluralSightMVC_App.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }

        public List<Pie> Pies { get; set; }
    }
}
