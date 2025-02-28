using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulky.Models;

namespace Bulky.DataAccess.Reponsitory.IReponsitory
{
    public interface ICategoryReponsitory: IReponsitory<Category>
    {
        void Update(Category obj);
    }
}
