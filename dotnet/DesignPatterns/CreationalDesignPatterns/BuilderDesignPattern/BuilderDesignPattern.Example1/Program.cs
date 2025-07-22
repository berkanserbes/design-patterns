
using BuilderDesignPattern.Example1;

var builder = new ReportBuilder();

var report = builder.SetHeader("header")
    .SetTitle("title")
    .SetContent("content")
    .SetFooter("footer")
    .SetFont("font")
    .Build();

Console.WriteLine(report.ToString());