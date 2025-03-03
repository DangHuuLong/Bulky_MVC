using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.DataAccess.Reponsitory.IReponsitory;

namespace BulkyBookBook.DataAccess.Reponsitory.IReponsitory
{
    public interface IUnitOfWork
    {
        ICategoryReponsitory Category { get; }
        IProductReponsitory Product { get; }
        ICompanyReponsitory Company { get; }
        IShoppingCartReponsitory ShoppingCart { get; }
        IApplicationUserReponsitory ApplicationUser { get; }
        IOrderHeaderReponsitory OrderHeader { get; }
        IOrderDetailReponsitory OrderDetail { get; }
        void Save();
    }
}
