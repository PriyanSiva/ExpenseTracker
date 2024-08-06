using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;

namespace ExpenseTracker.ViewModel
{
    class CategoryViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }

        public CategoryViewModel()
        {
            Categories = new ObservableCollection<Category>();
            // Load categories from data source
        }

        public void AddCategory(Category category)
        {
            Categories.Add(category);
            // Save category to data source
        }
    }
}
