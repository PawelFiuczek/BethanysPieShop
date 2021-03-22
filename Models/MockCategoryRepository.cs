﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category {CategoryID = 1, CategoryName = "Fruit pies", Description = "All-fruity pies"},
            new Category {CategoryID = 2, CategoryName = "Cheesecakes", Description = "Cheesy all the way"},
            new Category {CategoryID = 3, CategoryName = "Seasonal pies", Description = "Get in the mood for a seasonal pie"}
        };
    }
}
