/**
 * Abstract class defining the Template Method for the recruitment process.
 * The skeleton algorithm is fixed in executeRecruitmentProcess().
 * Subclasses override the steps they need to customize.
 */
export abstract class RecruitmentProcess {
  // Template Method — defines the invariant algorithm structure
  executeRecruitmentProcess(): void {
    this.receiveApplication();
    this.hrInterview();
    this.technicalInterview();
    this.interviewWithManager();
    this.notifyCandidate();
  }

  protected receiveApplication(): void {
    console.log("Candidate applied on LinkedIn");
  }

  protected hrInterview(): void {
    console.log("HR Interview completed");
  }

  // Abstract — every subclass MUST implement this
  protected abstract technicalInterview(): void;

  // Hook — subclasses may override (default: do nothing)
  protected interviewWithManager(): void {}

  // Hook — subclasses may override (default: email notification)
  protected notifyCandidate(): void {
    console.log("Candidate notified via email");
  }
}
