package behavioral.templatemethod.example1;

public class DeveloperRecruitmentProcess extends RecruitmentProcess {
    @Override
    protected void technicalInterview() {
        System.out.println("  [Step 3] Technical interview: Coding assessment + System design completed.");
    }

    @Override
    protected void interviewWithManager() {
        System.out.println("  [Step 4] Engineering manager interview + Culture fit assessment completed.");
    }

    @Override
    protected void notifyCandidate() {
        System.out.println("  [Step 5] Candidate notified: We are sorry, but we have decided not to move forward.");
    }
}
