using DatingWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingWebAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base(options) { }
        public  DbSet<Value> Values { get; set; }
    }
}