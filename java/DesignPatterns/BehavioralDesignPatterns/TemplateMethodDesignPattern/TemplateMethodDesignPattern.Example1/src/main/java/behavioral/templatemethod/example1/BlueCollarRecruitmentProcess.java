package behavioral.templatemethod.example1;

public class BlueCollarRecruitmentProcess extends RecruitmentProcess {
    @Override
    protected void technicalInterview() {
        System.out.println("  [Step 3] Technical interview: Practical skills assessment in workshop completed.");
    }
}
