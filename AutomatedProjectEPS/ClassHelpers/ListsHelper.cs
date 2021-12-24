using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.ClassHelpers
{
    class ListsHelper
    {
        public class ExpandersTree
        {
            public string Id { get; set; }
            public string Text { get; set; }
        }

        public class FiltersList
        {
            public string Filter { get; set; }
            public string Description { get; set; }
        }
    }
}
