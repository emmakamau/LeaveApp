using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeaveApp.Data;
using LeaveApp.Models;

namespace LeaveApp.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly LeaveApp.Data.LeaveAppContext _context;

        public IndexModel(LeaveApp.Data.LeaveAppContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Staff != null)
            {
                Staff = await _context.Staff.ToListAsync();
            }
        }
    }
}
