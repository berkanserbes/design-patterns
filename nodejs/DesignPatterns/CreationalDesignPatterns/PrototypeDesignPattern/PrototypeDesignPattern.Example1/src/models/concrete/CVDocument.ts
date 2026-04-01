import { DocumentBase } from '../abstract/DocumentBase';

export class PersonalInfo {
  fullName: string = '';
  email: string = '';
  phone: string = '';
  address: string = '';
}

export class WorkExperience {
  companyName: string = '';
  position: string = '';
  startDate: Date = new Date();
  endDate?: Date;
  description: string = '';
}

export class Education {
  institution: string = '';
  degree: string = '';
  fieldOfStudy: string = '';
  graduationYear: number = new Date().getFullYear();
}

export class CVDocument extends DocumentBase {
  personalInfo: PersonalInfo = new PersonalInfo();
  workExperiences: WorkExperience[] = [];
  skills: string[] = [];
  education: Education[] = [];

  constructor() {
    super();
    this.title = 'CV Template';
    this.content = 'Professional CV Template';
    this.metadata.tags.push('CV', 'Resume', 'Professional');
  }

  validateDocument(): boolean {
    return (
      !!this.personalInfo.fullName &&
      !!this.personalInfo.email &&
      this.education.length > 0
    );
  }

  override getDocumentInfo(): string {
    return `${super.getDocumentInfo()}, Applicant: ${this.personalInfo.fullName}, Experiences: ${this.workExperiences.length}`;
  }
}
