using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksProject.Models
{
    public class SearchViewModel
    {
        public bool IsNormalSearch { get; set; }

        public AccuracyEnum Accuracy { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string PublishPlace { get; set; }
        public string PublishDateFrom{ get; set; }
        public string PublishDateTo { get; set; }

        public string FullSearch { get; set; }
        public PriorityEnum Priority { get; set; }
    }
}
