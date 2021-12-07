using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using southcoast_address_book.Models;

namespace southcoast_address_book.Data
{
    public class southcoast_address_bookContext : DbContext
    {
        public southcoast_address_bookContext (DbContextOptions<southcoast_address_bookContext> options)
            : base(options)
        {
        }

        public DbSet<southcoast_address_book.Models.Person> Person { get; set; }
    }
}
