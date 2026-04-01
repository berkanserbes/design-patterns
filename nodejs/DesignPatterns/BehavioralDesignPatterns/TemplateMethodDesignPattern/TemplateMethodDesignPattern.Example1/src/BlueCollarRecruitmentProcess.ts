import { RecruitmentProcess } from "./RecruitmentProcess";

export class BlueCollarRecruitmentProcess extends RecruitmentProcess {
  protected technicalInterview(): void {
    console.log("Candidate was tested for practical skills in the workshop");
  }
}
