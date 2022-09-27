using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class Business
    {
        [Key]
        public long ID { get; set; }

        public string? Title { get; set; }

        public string? Endpoint { get; set; }

        public double? Distance { get; set; }

        public string? Netgisurl { get; set; }

        public string? Imageurl { get; set; }

        public string? Backgroundurl { get; set; }

        public bool? Visible { get; set; }

        public string? MemberKey { get; set; }

        public string? Theme { get; set; }

        public string? DefaultWorkSpace { get; set; }

        public string? GeoserverUrl { get; set; }

        public string? geoserverLayers { get; set; }

        public string? Bbox { get; set; }
    }
}
