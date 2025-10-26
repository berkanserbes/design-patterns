namespace TemplateMethodDesignPattern.Example1;

public abstract class RecruitmentProcess
{
    public void ExecuteRecruitmentProcess()
    {
        ReceiveApplication();
        HRInterview();
        TechnicalInterview();
        InterviewWithManager();
        NotifyCandidate();
    }

    protected void ReceiveApplication()
    {
        Console.WriteLine("Candidate applied on LinkedIn");
    }

    protected void HRInterview()
    {
        Console.WriteLine("HR Interview completed");
    }

    protected abstract void TechnicalInterview();

    protected virtual void InterviewWithManager() { }

    protected virtual void NotifyCandidate()
    {
        Console.WriteLine("Candidate notified via email");
    }

}
