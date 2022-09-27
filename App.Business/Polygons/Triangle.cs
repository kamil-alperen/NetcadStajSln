using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Polygons
{
    public class Triangle : BasePolygon
    {
        private readonly int[,] triangleCoordinates =
        {
            {2, 2},
            {4, 4},
            {5, 2},
            {2, 2}
        };
        public Triangle()
        {
            this.coordinates = triangleCoordinates;
        }
    }
}
