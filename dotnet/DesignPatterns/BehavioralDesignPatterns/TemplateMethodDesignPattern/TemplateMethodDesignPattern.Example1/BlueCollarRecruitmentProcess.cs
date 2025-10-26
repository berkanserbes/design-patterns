namespace TemplateMethodDesignPattern.Example1;

public class BlueCollarRecruitmentProcess : RecruitmentProcess
{
    protected override void TechnicalInterview()
    {
        Console.WriteLine("Candidate was tested for practical skills in the workshop");
    }
}
