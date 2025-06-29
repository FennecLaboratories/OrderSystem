using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OrderSystem.DataAccess.Entities;
namespace OrderSystem.DataAccess.Configurations;
public class CategoryConfigurations : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        builder.HasOne(c=>c.Item).WithMany().HasForeignKey(c=>c.ItemId);
    }
}