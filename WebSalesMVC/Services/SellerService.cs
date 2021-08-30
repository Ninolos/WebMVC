using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC.Data;
using WebSalesMVC.Models;

namespace WebSalesMVC.Services
{
    public class SellerService
    {
        private readonly WebSalesMVCContext _context; //dependency declared, readonly is a good pratice

        public SellerService(WebSalesMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); //sync operation
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
