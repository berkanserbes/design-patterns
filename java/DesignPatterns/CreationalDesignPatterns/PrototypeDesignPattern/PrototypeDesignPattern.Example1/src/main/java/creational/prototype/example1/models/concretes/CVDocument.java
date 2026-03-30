package creational.prototype.example1.models.concretes;

import creational.prototype.example1.models.abstracts.DocumentBase;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

public class CVDocument extends DocumentBase {
    public PersonalInfo          personalInfo    = new PersonalInfo();
    public List<WorkExperience>  workExperiences = new ArrayList<>();
    public List<String>          skills          = new ArrayList<>();
    public List<Education>       education       = new ArrayList<>();

    public CVDocument() {
        title   = "CV Template";
        content = "Professional CV Template";
        metadata.tags.addAll(List.of("CV", "Resume", "Professional"));
    }

    @Override
    public boolean validateDocument() {
        return personalInfo.fullName != null && !personalInfo.fullName.isBlank()
            && personalInfo.email    != null && !personalInfo.email.isBlank()
            && !education.isEmpty();
    }

    @Override
    public String getDocumentInfo() {
        return super.getDocumentInfo() +
               ", Applicant: " + personalInfo.fullName +
               ", Experiences: " + workExperiences.size();
    }

    public static class PersonalInfo {
        public String fullName = "";
        public String email    = "";
        public String phone    = "";
        public String address  = "";
    }

    public static class WorkExperience {
        public String        companyName  = "";
        public String        position     = "";
        public LocalDateTime startDate;
        public LocalDateTime endDate;
        public String        description  = "";
    }

    public static class Education {
        public String institution   = "";
        public String degree        = "";
        public String fieldOfStudy  = "";
        public int    graduationYear;
    }
}
