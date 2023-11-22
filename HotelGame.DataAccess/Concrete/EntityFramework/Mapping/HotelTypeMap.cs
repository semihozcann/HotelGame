using HotelGame.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGame.DataAccess.Concrete.EntityFramework.Mapping
{
    public class HotelTypeMap : IEntityTypeConfiguration<HotelType>
    {
        public void Configure(EntityTypeBuilder<HotelType> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(h => h.Id).ValueGeneratedOnAdd();

            builder.Property(h => h.Name).IsRequired();
            builder.Property(h => h.Name).HasMaxLength(50);
            builder.Property(h => h.Description).HasMaxLength(200);

            builder.ToTable("HotelTypes");

            builder.HasData(
                new HotelType
                {
                    Id = 1,
                    Name = "Butik Otel",
                });
        }
    }
}
