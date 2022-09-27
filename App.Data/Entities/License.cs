using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class License
    {
        [Key]
        public long ID { get; set; }

        public DateTime BeginningTime { get; set; }

        public DateTime EndingTime { get; set; }

        public string? Type { get; set; }

        public long BusinessID { get; set; }
        [ForeignKey("BusinessID")]
        public virtual Business? BusinessEntity { get; set; }

    }
}
