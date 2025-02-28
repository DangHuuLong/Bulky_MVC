using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Reponsitory;
using Bulky.DataAccess.Reponsitory.IReponsitory;
using BulkyBook.DataAccess.Reponsitory.IReponsitory;

namespace BulkyBook.DataAccess.Reponsitory
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryReponsitory Category { get; private set; }
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Category = new CategoryReponsitory(_db);
        }

        public void Save()
        {
            _db.SaveChanges();  
        }
    }
}
