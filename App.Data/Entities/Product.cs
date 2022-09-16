using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Model { get; set; } = String.Empty;

        public string Memory { get; set; } = String.Empty;

        public string Cpu { get; set; } = String.Empty;

        public int Price { get; set; } = 0;

        public string Description { get; set; } = String.Empty;

        public string Image { get; set; } = String.Empty;
    }
}
