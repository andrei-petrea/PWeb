using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobyLabWebProgramming.Core.Entities;
using System.Reflection.Emit;

namespace MobyLabWebProgramming.Infrastructure.EntityConfigurations;

public class ExpenseCategoryConfiguration : IEntityTypeConfiguration<ExpenseCategory>
{
    public void Configure(EntityTypeBuilder<ExpenseCategory> builder)
    {
        builder.HasKey(ec => new { ec.ExpenseId, ec.CategoryId });

        builder.HasOne(ec => ec.Expense)
            .WithMany(e => e.ExpenseCategories)
            .HasForeignKey(ec => ec.ExpenseId)
            .HasPrincipalKey(e => e.Id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ec => ec.Category)
            .WithMany(c => c.ExpenseCategories)
            .HasForeignKey(ec => ec.CategoryId)
            .HasPrincipalKey(e => e.Id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
