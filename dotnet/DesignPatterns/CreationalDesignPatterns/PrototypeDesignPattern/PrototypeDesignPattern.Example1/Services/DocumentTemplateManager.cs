using PrototypeDesignPattern.Example1.Models.Abstract;
using PrototypeDesignPattern.Example1.Models.Concrete;

namespace PrototypeDesignPattern.Example1.Services;

// Prototype Registry: stores pre-configured document templates and produces clones on demand
public class DocumentTemplateManager
{
    private readonly Dictionary<string, DocumentBase> _templates = new();

    public DocumentTemplateManager()
    {
        InitializeTemplates();
    }

    private void InitializeTemplates()
    {
        var cvTemplate = new CVDocument
        {
            Title = "Standard CV Template",
            PersonalInfo = new PersonalInfo
            {
                FullName = "[Your Name]",
                Email = "[your.email@example.com]",
                Phone = "[Your Phone]",
                Address = "[Your Address]"
            }
        };
        cvTemplate.Skills.AddRange(new[] { "[Skill 1]", "[Skill 2]", "[Skill 3]" });
        cvTemplate.Education.Add(new Education
        {
            Institution = "[University Name]",
            Degree = "[Degree]",
            FieldOfStudy = "[Field of Study]",
            GraduationYear = DateTime.Now.Year
        });

        var proposalTemplate = new ProposalDocument
        {
            Title = "Standard Business Proposal",
            ClientInfo = new ClientInfo
            {
                CompanyName = "[Client Company]",
                ContactPerson = "[Contact Person]",
                Email = "[client@example.com]"
            },
            Terms = "Standard terms and conditions apply.",
            ValidityDays = 30
        };
        proposalTemplate.ProposalItems.Add(new ProposalItem
        {
            Description = "[Service/Product Description]",
            Quantity = 1,
            UnitPrice = 0
        });

        var reportTemplate = new ReportDocument
        {
            Title = "Standard Report Template",
            ReportType = ReportType.Management,
            Header = new ReportHeader
            {
                Title = "[Report Title]",
                PreparedBy = "[Your Name]",
                Department = "[Department]"
            }
        };
        reportTemplate.Sections.Add(new ReportSection
        {
            SectionTitle = "Executive Summary",
            Content = "[Executive summary content]",
            Order = 1
        });

        RegisterTemplate("standard-cv", cvTemplate);
        RegisterTemplate("standard-proposal", proposalTemplate);
        RegisterTemplate("standard-report", reportTemplate);
    }

    public void RegisterTemplate(string templateId, DocumentBase template)
    {
        _templates[templateId] = template;
        Console.WriteLine($"Template registered: {templateId}");
    }

    public DocumentBase? CreateDocumentFromTemplate(string templateId)
    {
        if (!_templates.TryGetValue(templateId, out var template))
        {
            Console.WriteLine($"Template not found: {templateId}");
            return null;
        }
        return template.Clone();
    }

    public DocumentBase? CreateDocumentFromTemplateDeep(string templateId)
    {
        if (!_templates.TryGetValue(templateId, out var template))
        {
            Console.WriteLine($"Template not found: {templateId}");
            return null;
        }
        return template.DeepClone();
    }

    public void ListAvailableTemplates()
    {
        Console.WriteLine("\nAvailable Templates:");
        Console.WriteLine(new string('=', 50));
        foreach (var template in _templates)
            Console.WriteLine($"ID: {template.Key} - {template.Value.GetDocumentInfo()}");
    }

    public int GetTemplateCount() => _templates.Count;
}
