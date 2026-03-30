package behavioral.templatemethod.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Template Method Pattern - Recruitment Process ===\n");

        RecruitmentProcess[] processes = {
            new WhiteCollarRecruitmentProcess(),
            new BlueCollarRecruitmentProcess(),
            new DeveloperRecruitmentProcess()
        };

        for (RecruitmentProcess process : processes) {
            System.out.println("--- " + process.getClass().getSimpleName() + " ---");
            process.executeRecruitmentProcess();
            System.out.println();
        }
    }
}
