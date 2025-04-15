using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using BulkyWeb2.Models;


namespace BulkyWeb2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
           
        }
        public DbSet<Category> Categories { get; set; }
    }
}
