using AllinOneForDummies.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllinOneForDummies.Web.Pages.ViewComponents
{
    public class PlanetCountViewComponent : ViewComponent
    {
        private readonly IPlanetData _planetData;

        public PlanetCountViewComponent(IPlanetData planetData)
        {
            _planetData = planetData;
        }

        public IViewComponentResult Invoke()
        {
            var count = _planetData.GetCountOfPlanets();
            return View(count);
        } 
    }
}
