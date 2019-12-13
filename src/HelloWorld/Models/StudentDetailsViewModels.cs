using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class StudentDetailsViewModels
    {
        public Student Std { get; set;}
        public Address Adrs { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
    }
}
