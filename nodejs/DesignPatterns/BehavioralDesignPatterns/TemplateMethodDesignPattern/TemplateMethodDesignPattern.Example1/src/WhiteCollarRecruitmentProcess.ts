import { RecruitmentProcess } from "./RecruitmentProcess";

export class WhiteCollarRecruitmentProcess extends RecruitmentProcess {
  protected technicalInterview(): void {
    console.log("Candidate was tested for theoretical knowledge and problem-solving skills");
  }
}
