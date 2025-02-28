using BankingCreditSystem.Core.Repositories;

namespace BankingCreditSystem.Domain.Entities
{
    public abstract class Customer : Entity<Guid>
    {
        public string CustomerNumber { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Address { get; set; } = default!;
        public DateTime CustomerSince { get; set; } = DateTime.UtcNow;
        public decimal TotalAssets { get; set; }
        public string BranchCode { get; set; } = default!;
        protected Customer()
        {
            IsActive = true;
            IsDeleted = false;
        }
    }
} 