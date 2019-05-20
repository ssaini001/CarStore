using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarStoreServer.API.Controllers.Resources;
using CarStoreServer.API.Data;
using CarStoreServer.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarStoreServer.API.Controllers
{
    public class FeaturesController: Controller
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public FeaturesController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetAllFeatures()
        {
            var features = await _context.Features.ToListAsync();

            return _mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
        
    }
}