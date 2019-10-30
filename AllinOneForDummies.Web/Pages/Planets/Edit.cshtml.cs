using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllinOneForDummies.Core;
using AllinOneForDummies.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AllinOneForDummies.Web.Pages.Planets
{
    public class EditModel : PageModel
    {
        private readonly IPlanetData _planetData;
        private readonly IHtmlHelper _htmlHelper;

        [BindProperty]
        public Planet Planet { get; set; }
        public IEnumerable<SelectListItem> PlanetTypes { get; set; }

        public EditModel(IPlanetData planetData,
                         IHtmlHelper htmlHelper)
        {
            _planetData = planetData;
            _htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int? planetId)
        {
            PlanetTypes = _htmlHelper.GetEnumSelectList<PlanetType>();
            if (planetId.HasValue)
            {
                Planet = _planetData.GetPlanetById(planetId.Value);
            }
            else
            {
                Planet = new Planet();
            }
            if (Planet == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {            
            if (!ModelState.IsValid)
            {
                PlanetTypes = _htmlHelper.GetEnumSelectList<PlanetType>();
                return Page();
            }
            if (Planet.Id > 0)
            {
                _planetData.UpdatePlanet(Planet);
                TempData["Message"] = "Planet edited!";
            }
            else
            {
                _planetData.AddPlanet(Planet);
                TempData["Message"] = "Planet saved!";
            }
            _planetData.Commit();
            return RedirectToPage("./Detail", new { planetId = Planet.Id });

        }
    }
}