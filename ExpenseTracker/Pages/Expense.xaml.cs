using ExpenseTracker.Models;
using ExpenseTracker.ViewModel;
using Microsoft.Maui.Controls;
using ExpenseTracker.ViewModel;

namespace YourAppNamespace.Pages
{
    public partial class ExpensePage : ContentPage
    {
        private ExpenseViewModel viewModel;

        public ExpensePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ExpenseViewModel();
            LoadCategories();
        }

        private void LoadCategories()
        {
            CategoryPicker.ItemsSource = viewModel.GetCategories();
        }

        private void OnSaveExpenseClicked(object sender, EventArgs e)
        {
            var expense = new Expense
            {
                Amount = decimal.Parse(AmountEntry.Text),
                Date = DatePicker.Date,
                Description = DescriptionEntry.Text,
                Category = CategoryPicker.SelectedItem.ToString(),
                IsReimbursed = ReimbursedSwitch.IsToggled
            };

            viewModel.SaveExpense(expense);
        }
    }
}
