using App.Data.Context;
using App.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services
{
    public class CountryService
    {
        private readonly DataContext _context;

        public CountryService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Country>> GetCountryList(int limit)
        {
            var list = await _context.Countries.ToListAsync();
            if (limit > list.Count)
            {
                return list;
            }
            else
            {
                return list.GetRange(0, limit);
            }
        }
        public async Task<List<Country>> GetCountry(string reqName)
        {
            var countries = await _context.Countries.Where(country => EF.Functions.Like(country.Name, "%"+reqName+"%")).ToListAsync();
            return countries;
        }

        public async Task<int> GetSize()
        {
            var size = await _context.Countries.CountAsync();
            return size;
        }
    }
}
