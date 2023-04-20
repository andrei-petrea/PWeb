using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobyLabWebProgramming.Core.Entities;
using System.Reflection.Emit;

namespace MobyLabWebProgramming.Infrastructure.EntityConfigurations;

public class BillConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id)
            .IsRequired();
        builder.Property(e => e.Amount)
            .IsRequired();
        builder.Property(e => e.DueDate)
            .IsRequired();
        builder.Property(e => e.Description)
            .HasMaxLength(300);
        builder.Property(e => e.CreatedAt)
            .IsRequired();
        builder.Property(e => e.UpdatedAt)
            .IsRequired();

        builder.HasOne(b => b.User)
            .WithMany(u => u.Bills)
            .HasForeignKey(b => b.UserId)
            .HasPrincipalKey(b => b.Id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}