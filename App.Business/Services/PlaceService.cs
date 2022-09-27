using App.Business.Polygons;
using App.Data.Context;
using App.Data.Entities;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace App.Business.Services
{
    public class PlaceService
    {
        private readonly DataContext _context;

        public PlaceService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Place>> GetPlaceList()
        {
            var list = await _context.Places.ToListAsync();
            return list;
        }

        public async Task<Place> CreatePolygon(string name)
        {
            BasePolygon polygon = null;
            switch(name)
            {
                case "square":
                    polygon = new Square();
                    break;
                case "triangle":
                    polygon = new Polygons.Triangle();
                    break;
                default:
                    break;
            }
            var place = new Place()
            {
                Name = name,
                Location = polygon.GetPolygon()
            };

            _context.Places.Add(place);
            await _context.SaveChangesAsync();
            return place;
        }
      
    }
}
