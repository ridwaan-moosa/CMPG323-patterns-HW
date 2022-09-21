using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrgOffering.Data;
using OrgOffering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public class ProductRepository
    {
        protected readonly project3_hwContext _context = new project3_hwContext();

        // GET ALL: Products
        public IEnumerable<Products> GetAll()
        {
            return _context.Products.ToList();
        }

        // TO DO: Add ‘Get By Id’
        public async Task<Products> GetById(Guid? id)
        {
            var products = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);
            return (products);
        }

        // TO DO: Add ‘Create’

       
        // TO DO: Add ‘Edit’
        public async Task<Products> Edit(Guid? id)
        {
          
            var products = await _context.Products.FindAsync(id);
            
            return (products);
        }
        // TO DO: Add ‘Delete’
        public async Task<Products> Delete(Guid? id)
        {
            var products = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
       

            return (products);
        }
        // TO DO: Add ‘Exists’
        public bool Exists(Guid id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
