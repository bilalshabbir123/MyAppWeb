﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models.ViewModels
{
    public class CategoryVM
    {
        public Category Category { get; set; }
        public IEnumerable<Category> categories { get; set; }
    }
}
