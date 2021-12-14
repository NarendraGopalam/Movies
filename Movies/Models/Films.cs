using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Films
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public List<string> Movie { get; set; }

    }
}
