package creational.builder.example1;

public class Main {
    public static void main(String[] args) {
        Report report = new ReportBuilder()
                .setHeader("header")
                .setTitle("title")
                .setContent("content")
                .setFooter("footer")
                .setFont("font")
                .build();

        System.out.println(report);
    }
}
