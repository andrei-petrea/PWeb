using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobyLabWebProgramming.Core.Entities;
using System.Reflection.Emit;

namespace MobyLabWebProgramming.Infrastructure.EntityConfigurations;

public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
{
    public void Configure(EntityTypeBuilder<Expense> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id)
            .IsRequired();
        builder.Property(e => e.Amount)
            .IsRequired();
        builder.Property(e => e.Date)
            .IsRequired();
        builder.Property(e => e.Description)
            .HasMaxLength(300);
        builder.Property(e => e.CreatedAt)
            .IsRequired();
        builder.Property(e => e.UpdatedAt)
        .IsRequired();

        builder.HasOne(e => e.User)
            .WithMany(u => u.Expenses)
            .HasForeignKey(e => e.UserId)
            .HasPrincipalKey(e => e.Id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}

