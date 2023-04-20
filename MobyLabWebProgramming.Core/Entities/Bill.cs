using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobyLabWebProgramming.Core.Entities
{
    public class Bill : BaseEntity
    {
        /// <summary>
        /// Used to keep track of all my expenses.
        /// It has a many-to-one relation with User and Category.
        /// </summary>
        public decimal Amount { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime DueDate { get; set; } = default!;
        public bool IsPaid { get; set; } = false;

        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
