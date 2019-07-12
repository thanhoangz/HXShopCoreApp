using HXShopCoreApp.Data.EF.Extensions;
using HXShopCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HXShopCoreApp.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(x => x.Id).HasMaxLength(50).IsRequired().HasColumnType("VARCHAR(50)");
        }
    }
}
