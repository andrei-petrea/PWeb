using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobyLabWebProgramming.Core.Entities;
using System.Reflection.Emit;

namespace MobyLabWebProgramming.Infrastructure.EntityConfigurations;

public class IncomeConfiguration : IEntityTypeConfiguration<Income>
{
    public void Configure(EntityTypeBuilder<Income> builder)
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

        builder.HasOne(i => i.User)
            .WithMany(u => u.Incomes)
            .HasForeignKey(i => i.UserId)
            .HasPrincipalKey(i => i.Id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}