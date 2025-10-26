using TemplateMethodDesignPattern.Example1;

var processes = new RecruitmentProcess[]
       {
            new WhiteCollarRecruitmentProcess(),
            new BlueCollarRecruitmentProcess(),
            new DeveloperRecruitmentProcess()
       };

foreach (var process in processes)
{
    Console.WriteLine($"\n--- {process.GetType().Name} ---");
    process.ExecuteRecruitmentProcess();
}