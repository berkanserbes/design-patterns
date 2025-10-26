namespace TemplateMethodDesignPattern.Example1;

public class WhiteCollarRecruitmentProcess : RecruitmentProcess
{
    protected override void TechnicalInterview()
    {
        Console.WriteLine("Candidate was tested for theoretical knowledge and problem-solving skills");
    }
}
