using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationTeam.Models;

namespace WebApplicationTeam.DataAccess
{
    public class AppDbContext : DbContext //used to make a connection between tables and classes in the model class
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } //setting up the default settings of our db context connection 

        //create the db sets for our tables from the model class
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }

        //public DbSet<Location> Locations { get; set; } do not use, condensed into school table


    }
}
