using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSaleMvc.Data;
using WebSaleMvc.Models;

namespace WebSaleMvc.Services
{
    public class SellerService
    {
        private readonly WebSaleMvcContext _context;

        public SellerService(WebSaleMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
