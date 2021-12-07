using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using southcoast_address_book.Data;
using southcoast_address_book.Models;

namespace southcoast_address_book.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly southcoast_address_book.Data.southcoast_address_bookContext _context;

        public IndexModel(southcoast_address_book.Data.southcoast_address_bookContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
