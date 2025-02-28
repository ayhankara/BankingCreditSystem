namespace BankingCreditSystem.Domain.Entities
{
    public class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; } = default!;
        public string TaxNumber { get; set; } = default!;
        public string TaxOffice { get; set; } = default!;
        public string CompanyType { get; set; } = default!; // Limited, Anonim vs.
        public string CommercialRegistrationNumber { get; set; } = default!;
        public decimal AnnualTurnover { get; set; }
        public int NumberOfEmployees { get; set; }
        public DateTime EstablishmentDate { get; set; }
    }
} 