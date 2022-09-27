using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Polygons
{
    public class Square : BasePolygon
    {
        private readonly int[,] squareCoordinates = 
        {
            {0, 0},
            {1, 0},
            {1, 1},
            {0, 1},
            {0, 0}
        };
        public Square()
        {
            this.coordinates = squareCoordinates;
        }
        
    }
}
