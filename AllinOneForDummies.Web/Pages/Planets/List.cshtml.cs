using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllinOneForDummies.Core;
using AllinOneForDummies.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AllinOneForDummies.Web.Pages.Planets
{
    public class ListModel : PageModel
    {
        private readonly IPlanetData _planetData;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public IEnumerable<Planet> Planets { get; set; }

        public ListModel(IPlanetData planetData)
        {
            _planetData = planetData;
        }

        public void OnGet()
        {
           Planets = _planetData.GetPlanetsByName(SearchTerm);
        }
    }
}