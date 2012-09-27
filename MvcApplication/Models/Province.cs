using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Province
    {
        /// <summary>
        /// Province Name
        /// </summary>
        public string Name { get; set; }
        public int Population { get; set; }
        public string Iso { get; set; }
        public string Capital { get; set; }
        public int Area { get; set; }
        public decimal Density
        {
            get { return Population / Area; }
        }
    }
}