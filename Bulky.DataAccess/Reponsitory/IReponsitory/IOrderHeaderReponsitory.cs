using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Reponsitory.IReponsitory
{
    public interface IOrderHeaderReponsitory : IReponsitory<OrderHeader>
    {
        void Update(OrderHeader obj);
    }
}
