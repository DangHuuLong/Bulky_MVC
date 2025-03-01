using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Reponsitory.IReponsitory;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Reponsitory
{
    public class ProductReponsitory : Reponsitory<Product>, IProductReponsitory
    {
        private ApplicationDbContext _db;
        public ProductReponsitory(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u=>u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.Price100 = obj.Price100;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Category = obj.Category;
                objFromDb.Author = obj.Author;
                objFromDb.Description = obj.Description;
                if(objFromDb.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
