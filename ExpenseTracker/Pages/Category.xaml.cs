using ExpenseTracker.Models;
using ExpenseTracker.ViewModel;
using Microsoft.Maui.Controls;
using ExpenseTracker.Models;
using ExpenseTracker.ViewModel;

namespace YourAppNamespace.Pages
{
    public partial class CategoryPage : ContentPage
    {
        private CategoryViewModel viewModel;

        public CategoryPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CategoryViewModel();
        }

        private void OnAddCategoryClicked(object sender, EventArgs e)
        {
            var category = new Category
            {
                Name = NameEntry.Text,
                Description = DescriptionEditor.Text,
                BudgetLimit = decimal.Parse(BudgetEntry.Text),
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            viewModel.AddCategory(category);
        }
    }
}
