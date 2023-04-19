
using Lab___Objects__All_the_way_down;

class Program
{
    static void Main(string[] args)
    {
        Notebook.Notebooks notebook1 = new Notebook.Notebooks(Covers.CoverType.Spiral, Paper.PaperType.CollegeRule);
        Notebook.Notebooks notebook2 = new Notebook.Notebooks(Covers.CoverType.Scientific, Paper.PaperType.GraphPaper);
        Notebook.Notebooks notebook3 = new Notebook.Notebooks(Covers.CoverType.BulletJournals, Paper.PaperType.MonthlyCalendarPaper);

        Console.WriteLine("Notebook 1: " + notebook1.Cover + " cover, " + notebook1.Paper + " paper");
        Console.WriteLine("Notebook 2: " + notebook2.Cover + " cover, " + notebook2.Paper + " paper");
        Console.WriteLine("Notebook 3: " + notebook3.Cover + " cover, " + notebook3.Paper + " paper");

        Console.ReadLine();
    }
























}
