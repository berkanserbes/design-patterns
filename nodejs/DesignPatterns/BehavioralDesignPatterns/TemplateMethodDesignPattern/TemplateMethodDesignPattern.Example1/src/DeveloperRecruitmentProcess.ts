import { RecruitmentProcess } from "./RecruitmentProcess";

export class DeveloperRecruitmentProcess extends RecruitmentProcess {
  protected technicalInterview(): void {
    console.log(
      "Candidate was tested for coding skills and system design via online coding assessment"
    );
  }

  protected interviewWithManager(): void {
    console.log("Candidate interviewed with the Tech Lead and Engineering Manager");
  }

  protected notifyCandidate(): void {
    console.log(
      "We sincerely appreciate the time and effort you invested during the selection process.\n" +
        "After thoughtful evaluation, we have decided not to move forward with your application."
    );
  }
}
