using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobyLabWebProgramming.Core.Entities
{
    public class Income : BaseEntity
    {
        /// <summary>
        /// Tracking my income, the amount and where it came from, also the date i received it.
        /// Has a many-to-one relation with User and Category.
        /// </summary>
        public decimal Amount { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime Date { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;

        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
