using AllinOneForDummies.Core;
using AllinOneForDummies.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AllinOneForDummies.Web.Pages.Planets
{
    public class DeleteModel : PageModel
    {
        private readonly IPlanetData _planetData;
        public Planet Planet { get; set; }

        public DeleteModel(IPlanetData planetData)
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

        public IActionResult OnPost(int planetId)
        {
            var planet = _planetData.DeletePlanet(planetId);
            _planetData.Commit();
            if (planet == null)
            {
                return RedirectToPage("./NotFound");
            }
            TempData["Message"] = $"{planet.Name} deleted!";
            return RedirectToPage("./List");
        }
    }
}