using DataModel.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configuration
{
    public class CustomerWarrantyConfiguration : IEntityTypeConfiguration<CustomerWarranty>
    {
        public void Configure(EntityTypeBuilder<CustomerWarranty> builder)
        {
            builder.HasData
            (
                new CustomerWarranty
                {
                    id = 1,
                    name = "የሱፍ",
                    address = "ብቸና ከተማ",
                    region = "አማራ",
                    subCity = "ንፋስ ስልክ ላፍቶ",
                    woreda = "02",
                    customerId = 1
                },
                new CustomerWarranty
                {
                    id = 2,
                    name = "ሙሀመድ",
                    address = "ባቲ ከተማ",
                    region = "አማራ",
                    subCity = "ቦሌ",
                    woreda = "02",
                    customerId = 1
                },
                 new CustomerWarranty
                 {
                     id = 3,
                     name = "ሁንዴ",
                     address = "ጊንጪ ከተማ",
                     region = "ኦሮሚያ",
                     subCity = "ንፋስ ስልክ ላፍቶ",
                     woreda = "02",
                     customerId = 1
                 },
                  new CustomerWarranty
                  {
                      id = 4,
                      name = "ሰማይነህ",
                      address = "ብቸና ከተማ",
                      region = "አማራ",
                      subCity = "ንፋስ ስልክ ላፍቶ",
                      woreda = "02",
                      customerId = 1
                  }
            );
        }
    }
}

