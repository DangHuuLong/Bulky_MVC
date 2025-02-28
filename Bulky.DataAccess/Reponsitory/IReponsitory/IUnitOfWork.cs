using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulky.DataAccess.Reponsitory.IReponsitory;

namespace BulkyBook.DataAccess.Reponsitory.IReponsitory
{
    public interface IUnitOfWork
    {
        ICategoryReponsitory Category { get; }
        void Save();
    }
}
