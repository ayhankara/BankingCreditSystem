using BankingCreditSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankingCreditSystem.Persistence.EntityConfigurations
{
    public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
    {
        public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
        {
            builder.ToTable("CorporateCustomers");

            builder.Property(c => c.CompanyName)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(c => c.TaxNumber)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.TaxOffice)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.CompanyType)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.CommercialRegistrationNumber)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasIndex(c => c.TaxNumber)
                .IsUnique();
        }
    }
} 