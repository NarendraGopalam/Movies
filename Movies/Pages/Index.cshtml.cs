using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Films> Films;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Films = new List<Films>(); 
            Films.Add(new Models.Films() { Title="FairyTail",Duration="02:00",Description="Magical World",Movie=new List<string>() { "Natsu is Lead Role","Erza is Powerful"} });
            Films.Add(new Models.Films() { Title = "Naruto", Duration = "03:00", Description = "Martial Arts", Movie = new List<string>() { "Naruto is an orphan","Sasuke is his best friend" } });
            Films.Add(new Models.Films() { Title = "One Pieace", Duration = "01:50", Description = "Adventure", Movie = new List<string>() { "Luffy is Elastic Man","Luffy starts his journey in search of One Pieace" } });
        }

        public IActionResult OnGet()
        {

            return Page();
        }
    }
}
