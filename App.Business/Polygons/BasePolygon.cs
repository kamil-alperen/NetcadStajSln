using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Polygons
{
    public class BasePolygon
    {
        public int[,] coordinates;
        public Polygon GetPolygon()
        {
            var coordinateList = new Coordinate[this.coordinates.GetLength(0)];
            for (int i = 0; i < this.coordinates.GetLength(0); i++)
            {
                coordinateList[i] = new Coordinate(this.coordinates[i, 0], this.coordinates[i, 1]);
            }

            var polygon = new Polygon(new LinearRing(coordinateList));

            return polygon;
        }
    }
}
