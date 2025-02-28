﻿using System;
using System.Collections.Generic;

namespace BulkyBook.DataAccess.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public string Author { get; set; } = null!;

    public double ListPrice { get; set; }

    public double Price { get; set; }

    public double Price50 { get; set; }

    public double Price100 { get; set; }

    public int CategoryId { get; set; }
}
