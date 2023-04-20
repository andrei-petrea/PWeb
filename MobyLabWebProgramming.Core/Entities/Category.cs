using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobyLabWebProgramming.Core.Entities
{
    public class Category : BaseEntity
    {
        /// <summary>
        /// Used to keep track of all my expenses.
        /// It has a many-to-one relation with User and a 
        /// many-to-many relation with Expense.
        /// </summary>
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

        public ICollection<ExpenseCategory> ExpenseCategories { get; set; } = default!;
    }
}
