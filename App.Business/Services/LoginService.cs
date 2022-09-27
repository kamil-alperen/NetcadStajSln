using App.Data.Context;
using App.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Business.Services
{
    public class LoginService
    {
        private readonly DataContext _context;

        public LoginService(DataContext context)
        {
            _context = context;
        }


        public async Task<List<Data.Entities.Business>> GetBusinessList()
        {
            var list = await _context.Businesses.ToListAsync();
            return list;
        }

        public async Task<Data.Entities.Business> AddBusiness(Data.Entities.Business request)
        {
            _context.Businesses.Add(request);
            await _context.SaveChangesAsync();
            return request;
        }
    }
}
