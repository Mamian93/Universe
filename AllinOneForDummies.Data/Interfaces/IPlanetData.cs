using AllinOneForDummies.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllinOneForDummies.Core.Interfaces
{
    public interface IPlanetData
    {
        IEnumerable<Planet> GetPlanets();

        Planet GetPlanetById(int planetId);

        Planet UpdatePlanet(Planet planet);

        Planet AddPlanet(Planet planet);

        Planet DeletePlanet(int planetId);

        int Commit();

        IEnumerable<Planet> GetPlanetsByName(string planetName);

        int GetCountOfPlanets();
    }
}
