package behavioral.templatemethod.example1;

public abstract class RecruitmentProcess {
    // Template method
    public final void executeRecruitmentProcess() {
        receiveApplication();
        hrInterview();
        technicalInterview();
        interviewWithManager();
        notifyCandidate();
    }

    protected void receiveApplication() {
        System.out.println("  [Step 1] Application received and reviewed.");
    }

    protected void hrInterview() {
        System.out.println("  [Step 2] HR interview completed.");
    }

    protected abstract void technicalInterview();

    protected void interviewWithManager() {
        System.out.println("  [Step 4] Manager interview completed.");
    }

    protected void notifyCandidate() {
        System.out.println("  [Step 5] Candidate notified: Congratulations! You are hired.");
    }
}
