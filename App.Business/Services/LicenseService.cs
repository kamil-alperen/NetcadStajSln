using App.Data.Context;
using App.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Business.Models.License;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;

namespace App.Business.Services
{
    public class LicenseService
    {
        private readonly DataContext _context;

        public LicenseService(DataContext context)
        {
            _context = context;
        }

        public async Task<LicenseResponse> GetLicense(long businessID)
        {

            DateTime current = DateTime.Now;

            License license = (await _context.Licenses.Where(l => l.BusinessID == businessID).ToListAsync())[0];

            DateTime begginningTime = license.BeginningTime;
            DateTime endingTime = license.EndingTime;

            int compare = DateTime.Compare(license.EndingTime, current);

            LicenseResponse response = compare >= 0 ? new LicenseResponse(false, begginningTime, endingTime) : new LicenseResponse(true, begginningTime, endingTime);

            return response;
        }

        public async Task<License> AddLicense(License license)
        {
            _context.Licenses.Add(license);
            await _context.SaveChangesAsync();
            return license;
        }
    }
}
