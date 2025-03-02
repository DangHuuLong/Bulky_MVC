using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Reponsitory;
using BulkyBook.DataAccess.Reponsitory.IReponsitory;
using BulkyBookBook.DataAccess.Reponsitory.IReponsitory;

namespace BulkyBookBook.DataAccess.Reponsitory
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryReponsitory Category { get; private set; }
        public ICompanyReponsitory Company { get; private set; }
        public IProductReponsitory Product { get; private set; }
        public IShoppingCartReponsitory ShoppingCart { get; private set; }
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            ShoppingCart = new ShoppingCartReponsitory(_db);
            Category = new CategoryReponsitory(_db);
            Product = new ProductReponsitory(_db);
            Company = new CompanyReponsitory(_db);
        }

        public void Save()
        {
            _db.SaveChanges();  
        }
    }
}
