﻿using System;
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
    public class CategoryReponsitory : Reponsitory<Category>, ICategoryReponsitory
    {
        private ApplicationDbContext _db;
        public CategoryReponsitory(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
