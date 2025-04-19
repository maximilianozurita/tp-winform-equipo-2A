using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ArticuloSimple
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Brand { get; set; }
        public int Category { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
    }
}
