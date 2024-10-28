using CompositePatern;

class Program
{
    static void Main(string[] args)
    {
        Document document = new Document();

        Section section1 = new Section("Introduction");
        section1.Add(new Paragraph("1 this book is about"));
        section1.Add(new Paragraph("2 table of contents"));
        section1.Add(new Paragraph("3 author's words"));

        Section section2 = new Section("Main Content");
        section2.Add(new Paragraph("1 a long time ago..."));
        section2.Add(new Paragraph("2 was a warrior..."));
        section2.Add(new Paragraph("3 who will die..."));

        Section subsection = new Section("Subsection");

        subsection.Add(new Paragraph("1 warrior fights a lot "));
        Paragraph fordelete = new ("2 nand never lost");
        Paragraph fordelete_ = new("3 but once");
        subsection.Add(fordelete);
        subsection.Add(fordelete_);

        section2.Add(subsection);

        Section subsubsection = new Section("Subsubsection");

        
        subsubsection.Add(new Paragraph("he fought a dragon"));
        subsubsection.Add(new Paragraph("and was seriously injured"));

        Section  section3 = new Section("Ending");

        section3.Add(new Paragraph("He died!!!"));

        subsection.Add(subsubsection);

        document.AddSection(section1);
        document.AddSection(section2);
        document.AddSection(section3);

        document.Display();
        
        subsection.Remove(fordelete_);
        subsection.Remove(fordelete);
        document.RemoveSection(section3);
        Console.WriteLine(" ////////////////////////////");

        document.Display();
    }
}
