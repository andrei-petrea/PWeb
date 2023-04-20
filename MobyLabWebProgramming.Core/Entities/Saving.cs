using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobyLabWebProgramming.Core.Entities
{
    public class Saving : BaseEntity
    {
        /// <summary>
        /// Amounts I manage to save for certain financial goals.
        /// Has a many-to-one relation with User and Category.
        /// </summary>
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;

        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
