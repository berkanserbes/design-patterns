package creational.prototype.example1.models.concretes;

import creational.prototype.example1.models.abstracts.DocumentBase;

import java.util.ArrayList;
import java.util.List;

public class ProposalDocument extends DocumentBase {
    public ClientInfo        clientInfo     = new ClientInfo();
    public List<ProposalItem> proposalItems = new ArrayList<>();
    public double            totalAmount;
    public int               validityDays   = 30;
    public String            terms          = "";

    public ProposalDocument() {
        title   = "Business Proposal Template";
        content = "Professional Business Proposal";
        metadata.tags.addAll(List.of("Proposal", "Business", "Sales"));
    }

    @Override
    public boolean validateDocument() {
        return clientInfo.companyName != null && !clientInfo.companyName.isBlank()
            && !proposalItems.isEmpty()
            && totalAmount > 0;
    }

    public void calculateTotal() {
        totalAmount = proposalItems.stream()
                .mapToDouble(i -> i.quantity * i.unitPrice)
                .sum();
    }

    @Override
    public String getDocumentInfo() {
        return super.getDocumentInfo() +
               ", Client: " + clientInfo.companyName +
               ", Total: $" + String.format("%.2f", totalAmount) +
               ", Items: " + proposalItems.size();
    }

    public static class ClientInfo {
        public String companyName    = "";
        public String contactPerson  = "";
        public String email          = "";
        public String address        = "";
    }

    public static class ProposalItem {
        public String description = "";
        public int    quantity;
        public double unitPrice;
        public String notes = "";
    }
}
