using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    class Expense
    {
        /// <summary>
        /// Gets or sets the unique identifier for the expense.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the amount of money spent in this expense.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the date when the expense was incurred.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets a description of the expense.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the category of the expense.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether the expense has been reimbursed.
        /// </summary>
        public bool IsReimbursed { get; set; }
    }
}
