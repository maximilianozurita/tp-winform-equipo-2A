using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_winform_equipo_2A.Models
{
    public class Product
    {
        public string Code {  get; set; }
        public string Name { get; set; }
        public string Description {  get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
    }
}
