using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Civil.Data.EF.Entities
{
    public class Employees
    {
        public int employeeid { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string joindate { get; set; }
        public string mobilenumber { get; set; }
    }
}
