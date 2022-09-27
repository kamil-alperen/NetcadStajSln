﻿using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public Polygon Location { get; set; } = null;
    }
}
