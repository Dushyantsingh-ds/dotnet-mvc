using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace _01_CodeFirst.Enity
{
    public class DataContext :DbContext
    {
        public void DataContext() :Base("Conn")
    {

    }
    }
}