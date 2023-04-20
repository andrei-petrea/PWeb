using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobyLabWebProgramming.Core.Entities
{
    public class ExpenseCategory
    {
        /// <summary>
        /// Used to facilitate the many-to-many relation between Expense and Category.
        /// </summary>
        public Guid ExpenseId { get; set; }
        public Expense Expense { get; set; } = default!;

        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
