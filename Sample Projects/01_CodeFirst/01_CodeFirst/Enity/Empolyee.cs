using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace _01_CodeFirst.Enity
{
    public class Empolyee
    {

        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Add { get; set; }
    }
}