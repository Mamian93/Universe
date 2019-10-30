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
    public class DetailModel : PageModel
    {
        private readonly IPlanetData _planetData;

        [TempData]
        public string Message { get; set; }

        public Planet Planet { get; set; }

        public DetailModel(IPlanetData planetData)
        {
            _planetData = planetData;
        }

        public IActionResult OnGet(int planetId)
        {
            Planet = _planetData.GetPlanetById(planetId);
            if (Planet == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}