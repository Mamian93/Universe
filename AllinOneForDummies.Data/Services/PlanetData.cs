using AllinOneForDummies.Core;
using AllinOneForDummies.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllinOneForDummies.Core.Services
{
    public class PlanetData : IPlanetData
    {
        private DummiesContext context;

        public PlanetData(DummiesContext context)
        {
            this.context = context;
        }

        public Planet AddPlanet(Planet planet)
        {
            context.Planets.Add(planet);
            return planet;
        }

        public Planet DeletePlanet(int planetId)
        {
            var planet = GetPlanetById(planetId);
            if (planet != null)
            {
                context.Planets.Remove(planet);
            }
            return planet;
        }

        public Planet GetPlanetById(int planetId)
        {
            return context.Planets.Find(planetId);
        }

        public IEnumerable<Planet> GetPlanets()
        {
            return context.Planets;
        }

        public Planet UpdatePlanet(Planet planet)
        {
            var entity = context.Planets.Attach(planet);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return planet;
        }

        public int Commit()
        {
            return context.SaveChanges();
        }

        public IEnumerable<Planet> GetPlanetsByName(string planetName)
        {
            return context.Planets.Where(a => string.IsNullOrEmpty(planetName) || a.Name.StartsWith(planetName));
        }

        public int GetCountOfPlanets()
        {
            return context.Planets.Count();
        }
    }
}
