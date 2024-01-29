using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSaleMvc.Data;
using WebSaleMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSaleMvc.Services
{
    public class DepartmentService
    {
        private readonly WebSaleMvcContext _context;

        public DepartmentService(WebSaleMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>>FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
