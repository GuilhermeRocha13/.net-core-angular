using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro.API.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Place { get; set; }
        public string DateEvent { get; set; }
        public string Theme { get; set; }
        public int Qtpple { get; set; }
        public string lot { get; set; }
        public string ImageURL { get; set; }
    }
}