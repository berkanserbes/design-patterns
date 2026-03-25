using PrototypeDesignPattern.Example1.Models.Abstract;

namespace PrototypeDesignPattern.Example1.Models.Concrete;

public class CVDocument : DocumentBase
{
    public PersonalInfo PersonalInfo { get; set; } = new();
    public List<WorkExperience> WorkExperiences { get; set; } = new();
    public List<string> Skills { get; set; } = new();
    public List<Education> Education { get; set; } = new();

    public CVDocument()
    {
        Title = "CV Template";
        Content = "Professional CV Template";
        Metadata.Tags.AddRange(new[] { "CV", "Resume", "Professional" });
    }

    public override bool ValidateDocument() =>
        !string.IsNullOrEmpty(PersonalInfo.FullName) &&
        !string.IsNullOrEmpty(PersonalInfo.Email) &&
        Education.Count > 0;

    public override string GetDocumentInfo() =>
        $"{base.GetDocumentInfo()}, Applicant: {PersonalInfo.FullName}, Experiences: {WorkExperiences.Count}";
}

public class PersonalInfo
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}

public class WorkExperience
{
    public string CompanyName { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Description { get; set; } = string.Empty;
}

public class Education
{
    public string Institution { get; set; } = string.Empty;
    public string Degree { get; set; } = string.Empty;
    public string FieldOfStudy { get; set; } = string.Empty;
    public int GraduationYear { get; set; }
}
