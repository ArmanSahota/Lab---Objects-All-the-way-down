using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab___Objects__All_the_way_down.Notebook;

namespace Lab___Objects__All_the_way_down
{
    internal class Notebook
    {
        public class Notebooks
        {
            public Covers.CoverType Cover { get; set; }
            public Paper.PaperType Paper { get; set; }

            public Notebooks(Covers.CoverType cover, Paper.PaperType paper)
            {
                Cover = cover;
                Paper = paper;
            }
        }
        
    }
}
