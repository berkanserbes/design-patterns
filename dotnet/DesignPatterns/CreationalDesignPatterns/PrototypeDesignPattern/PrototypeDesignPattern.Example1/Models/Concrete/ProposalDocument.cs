using PrototypeDesignPattern.Example1.Models.Abstract;

namespace PrototypeDesignPattern.Example1.Models.Concrete;

public class ProposalDocument : DocumentBase
{
    public ClientInfo ClientInfo { get; set; } = new();
    public List<ProposalItem> ProposalItems { get; set; } = new();
    public decimal TotalAmount { get; set; }
    public int ValidityDays { get; set; } = 30;
    public string Terms { get; set; } = string.Empty;

    public ProposalDocument()
    {
        Title = "Business Proposal Template";
        Content = "Professional Business Proposal";
        Metadata.Tags.AddRange(new[] { "Proposal", "Business", "Sales" });
    }

    public override bool ValidateDocument() =>
        !string.IsNullOrEmpty(ClientInfo.CompanyName) &&
        ProposalItems.Count > 0 &&
        TotalAmount > 0;

    public void CalculateTotal() =>
        TotalAmount = ProposalItems.Sum(item => item.Quantity * item.UnitPrice);

    public override string GetDocumentInfo() =>
        $"{base.GetDocumentInfo()}, Client: {ClientInfo.CompanyName}, Total: ${TotalAmount:N2}, Items: {ProposalItems.Count}";
}

public class ClientInfo
{
    public string CompanyName { get; set; } = string.Empty;
    public string ContactPerson { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}

public class ProposalItem
{
    public string Description { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public string Notes { get; set; } = string.Empty;
}
