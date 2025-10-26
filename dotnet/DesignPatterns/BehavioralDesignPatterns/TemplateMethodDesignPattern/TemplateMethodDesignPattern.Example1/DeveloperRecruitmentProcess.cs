namespace TemplateMethodDesignPattern.Example1;

public class DeveloperRecruitmentProcess : RecruitmentProcess
{
    protected override void TechnicalInterview()
    {
        Console.WriteLine("Candidate was tested for coding skills and system design via online coding assessment");
    }

    protected override void InterviewWithManager()
    {
        Console.WriteLine("Candidate interviewed with the Tech Lead and Engineering Manager");
    }

    protected override void NotifyCandidate()
    {
        Console.WriteLine("We sincerely appreciate the time and effort you invested during the selection process.\nAfter thoughtful evaluation, we have decided not to move forward with your application.");
    }
}
