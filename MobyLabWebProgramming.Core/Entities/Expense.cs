using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobyLabWebProgramming.Core.Entities
{
    public class Expense : BaseEntity
    {
        /// <summary>
        /// Used to keep track of all my expenses.
        /// It has a many-to-one relation with User and Category and a 
        /// many-to-many relation with Category.
        /// </summary>
        public decimal Amount { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime Date { get; set; } = default!;

        public Guid UserId { get; set; }
        public User User { get; set; } = default!;

        public ICollection<ExpenseCategory> ExpenseCategories { get; set; } = default!;
    }
}
