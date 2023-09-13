using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;


namespace Data.Data
{
    public class BlogDbContext : DbContext
    {

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }


        public DbSet<Blog>Blogs { get; set; }


    }
}
