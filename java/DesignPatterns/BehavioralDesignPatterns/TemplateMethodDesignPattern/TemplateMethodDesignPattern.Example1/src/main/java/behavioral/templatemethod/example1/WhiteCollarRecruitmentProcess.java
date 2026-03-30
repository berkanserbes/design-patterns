package behavioral.templatemethod.example1;

public class WhiteCollarRecruitmentProcess extends RecruitmentProcess {
    @Override
    protected void technicalInterview() {
        System.out.println("  [Step 3] Technical interview: Theoretical knowledge test completed.");
    }
}
