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
    public class MakesController : Controller
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public MakesController(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;

        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes =  await _context.Makes.Include(m => m.Models).ToListAsync();

            return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}