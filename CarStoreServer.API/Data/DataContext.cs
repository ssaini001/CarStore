using CarStoreServer.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CarStoreServer.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        public DbSet<Model> Models { get; set; }
        public DbSet<Make> Makes { get; set; }

        public DbSet<Feature> Features { get; set; }
        
    }
}