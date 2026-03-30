package creational.builder.example1;

public class Report {
    public String title   = "";
    public String content = "";
    public String header;
    public String footer;
    public String font;

    @Override
    public String toString() {
        return "Report:\nTitle: " + title + "\nContent: " + content +
               "\nHeader: " + header + "\nFooter: " + footer + "\nFont: " + font;
    }
}
