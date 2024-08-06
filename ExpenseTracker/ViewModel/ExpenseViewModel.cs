using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;

namespace ExpenseTracker.ViewModel
{
    class ExpenseViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }

        public ExpenseViewModel()
        {
            Categories = new ObservableCollection<Category>();
            // Load categories from data source
        }

        public IEnumerable<Category> GetCategories()
        {
            return Categories;
        }

        public void SaveExpense(Expense expense)
        {
            // Save expense to data source
        }
    }
}
