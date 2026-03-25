using PrototypeDesignPattern.Example1.Models.Concrete;
using PrototypeDesignPattern.Example1.Services;

Console.WriteLine("Prototype Design Pattern - Document Template System");
Console.WriteLine(new string('=', 60));

var templateManager = new DocumentTemplateManager();
templateManager.ListAvailableTemplates();

// --- CV Documents ---
Console.WriteLine("\n--- CV Documents ---");
var cv1 = templateManager.CreateDocumentFromTemplate("standard-cv") as CVDocument;
var cv2 = templateManager.CreateDocumentFromTemplateDeep("standard-cv") as CVDocument;

if (cv1 != null && cv2 != null)
{
    cv1.PersonalInfo.FullName = "John Doe";
    cv1.PersonalInfo.Email = "john.doe@email.com";
    cv1.Skills.Add("C# Programming");
    cv1.WorkExperiences.Add(new WorkExperience
    {
        CompanyName = "Tech Corp",
        Position = "Senior Developer",
        StartDate = DateTime.Now.AddYears(-2)
    });

    cv2.PersonalInfo.FullName = "Jane Smith";
    cv2.PersonalInfo.Email = "jane.smith@email.com";
    cv2.Skills.Clear();
    cv2.Skills.AddRange(new[] { "Project Management", "Team Leadership", "Agile" });

    Console.WriteLine($"CV1: {cv1.GetDocumentInfo()} | Valid: {cv1.ValidateDocument()}");
    Console.WriteLine($"CV2: {cv2.GetDocumentInfo()} | Valid: {cv2.ValidateDocument()}");
}

// --- Business Proposals ---
Console.WriteLine("\n--- Business Proposals ---");
var proposal1 = templateManager.CreateDocumentFromTemplate("standard-proposal") as ProposalDocument;
var proposal2 = templateManager.CreateDocumentFromTemplate("standard-proposal") as ProposalDocument;

if (proposal1 != null && proposal2 != null)
{
    proposal1.ClientInfo.CompanyName = "ABC Corp";
    proposal1.ClientInfo.ContactPerson = "Alice Johnson";
    proposal1.ProposalItems.Add(new ProposalItem { Description = "Software Development", Quantity = 1, UnitPrice = 50000 });
    proposal1.ProposalItems.Add(new ProposalItem { Description = "Training Services", Quantity = 2, UnitPrice = 5000 });
    proposal1.CalculateTotal();

    proposal2.ClientInfo.CompanyName = "XYZ Ltd";
    proposal2.ClientInfo.ContactPerson = "Bob Wilson";
    proposal2.ProposalItems.Clear();
    proposal2.ProposalItems.Add(new ProposalItem { Description = "Consulting Services", Quantity = 10, UnitPrice = 2000 });
    proposal2.CalculateTotal();

    Console.WriteLine($"Proposal1: {proposal1.GetDocumentInfo()} | Valid: {proposal1.ValidateDocument()}");
    Console.WriteLine($"Proposal2: {proposal2.GetDocumentInfo()} | Valid: {proposal2.ValidateDocument()}");
}

// --- Report Documents ---
Console.WriteLine("\n--- Report Documents ---");
var report1 = templateManager.CreateDocumentFromTemplateDeep("standard-report") as ReportDocument;

if (report1 != null)
{
    report1.Header.Title = "Q4 2024 Financial Report";
    report1.Header.PreparedBy = "Finance Team";
    report1.Header.Department = "Finance";
    report1.ReportType = ReportType.Financial;
    report1.Sections.Add(new ReportSection { SectionTitle = "Revenue Analysis", Content = "Detailed revenue analysis for Q4 2024", Order = 2 });
    report1.Summary.ExecutiveSummary = "Strong performance in Q4 2024";
    report1.Summary.Recommendations.AddRange(new[] { "Continue current strategy", "Invest in new markets" });

    Console.WriteLine($"Report1: {report1.GetDocumentInfo()} | Valid: {report1.ValidateDocument()}");
}

// --- Shallow vs Deep Clone ---
Console.WriteLine("\n--- Shallow vs Deep Clone ---");
var original = templateManager.CreateDocumentFromTemplate("standard-proposal") as ProposalDocument;
var shallow  = original?.Clone() as ProposalDocument;
var deep     = original?.DeepClone() as ProposalDocument;

if (original != null && shallow != null && deep != null)
{
    original.ClientInfo.CompanyName = "Modified Company";
    Console.WriteLine($"Original:      {original.ClientInfo.CompanyName}");
    Console.WriteLine($"Shallow Clone: {shallow.ClientInfo.CompanyName}");  // shares reference -> same value
    Console.WriteLine($"Deep Clone:    {deep.ClientInfo.CompanyName}");     // independent copy -> original value
}

// --- Performance: 1000 Clones ---
Console.WriteLine("\n--- Performance: 1000 Clones ---");
var sw = System.Diagnostics.Stopwatch.StartNew();
for (int i = 0; i < 1000; i++)
    templateManager.CreateDocumentFromTemplate("standard-cv");
sw.Stop();
Console.WriteLine($"Shallow Clone (1000x): {sw.ElapsedMilliseconds}ms");

sw.Restart();
for (int i = 0; i < 1000; i++)
    templateManager.CreateDocumentFromTemplateDeep("standard-cv");
sw.Stop();
Console.WriteLine($"Deep Clone    (1000x): {sw.ElapsedMilliseconds}ms");
