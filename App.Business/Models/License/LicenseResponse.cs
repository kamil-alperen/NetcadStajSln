using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Models.License
{
    public class LicenseResponse
    {
        public bool LicenseExpired { get; set; }
        public DateTime? LicenseBeginningTime { get; set; }
        public DateTime? LicenseEndingTime { get; set; }
        public LicenseResponse(bool licenseExpired, DateTime? beginningTime, DateTime? endingTime)
        {
            LicenseExpired = licenseExpired;
            LicenseBeginningTime = beginningTime;
            LicenseEndingTime = endingTime;
        }
    }
}
