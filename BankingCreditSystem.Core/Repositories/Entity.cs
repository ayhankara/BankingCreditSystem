namespace BankingCreditSystem.Core.Repositories
{
    public abstract class Entity<TId>
    {
        public TId Id { get; set; } = default!;
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    protected Entity()
    {
        Id = default!;
        CreateDate = DateTime.UtcNow;
        UpdateDate = null;
        DeletedDate = null;
    }
    }
   
} 