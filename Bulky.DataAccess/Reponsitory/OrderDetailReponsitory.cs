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
    public class OrderDetailReponsitory : Reponsitory<OrderDetail>, IOrderDetailReponsitory
    {
        private ApplicationDbContext _db;
        public OrderDetailReponsitory(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
