using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ProvincesRepository
    {
        public IEnumerable<Province> GetAll()
        {
            return new[]
            {
                new Province() 
                { 
                    Name = "Buenos Aires", 
                    Iso = "AR-B",
                    Population = 15625084,
                    Area = 307571,
                    Capital = "La Plata"
                }
            }.OrderBy(x => x.Name);
        }
    }
}