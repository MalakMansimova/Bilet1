using Bilet_1Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Bilet_1Project.DAL
{
    public class AddDbContext:DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options):base(options) 
        {

        }
        public DbSet<Recent> Recents { get; set; }
    }
   
}
