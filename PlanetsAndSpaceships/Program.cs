using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> newPlanetList = new List<string>() { "Neptune", "Pluto" };

            var mercuryProbes = new List<string>() { "Mariner", "Messenger", "BepiColombo" };
            var venusProbes = new List<string>() { "Mariner 10", "Galileo", "MESSENGER" };
            var earthProbes = new List<string>() {  "Mariner 10", "Pioneer 10", "Pioneer 11" };
            var marsProbes = new List<string>() { "Mariner 8", "Viking 1 Orbiter", "Viking 2 Orbiter" };
            var jupiterProbes = new List<string>() { "Pioneer 10", "Juno", "Cassini" };
            var saturnProbes = new List<string>() { "Pioneer 11", "Voyager 1", "Voyager 2" };
            var uranusProbes = new List<string>() { "Voyager 2" };
            var neptuneProbes = new List<string>() { "Voyager 2" };
            var plutoProbes = new List<string>() { "New Horizons" };

            var solarSystemProbes = new Dictionary<string, List<string>>()
            {
                { "Mercury", mercuryProbes },
                { "Venus" , venusProbes },
                { "Earth", earthProbes },
                { "Mars", marsProbes },
                { "Jupiter", jupiterProbes },
                { "Saturn", saturnProbes },
                { "Uranus", uranusProbes },
                { "Neptune", neptuneProbes },
                { "Pluto", plutoProbes }
            };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange(newPlanetList);

            planetList.Insert(2, "Venus");
            planetList.Insert(3, "Earth");
            planetList.Insert(6, "Uranus");

            var rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            foreach(string planet in planetList)
            {
                foreach(var (key, value) in solarSystemProbes)
                {
                    if(planet == key)
                    {
                        foreach(string satellite in value)
                        Console.WriteLine($"{satellite} visited the planet {planet}.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
