using System;
using System.Collections.Generic;

public class SpaceAge
{
    private const int EarthYear = 31557600;

    public enum Planet
    {
        Earth,
        Mercury,
        Venus,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    };

    private readonly Dictionary<Planet, double> yearLenDict = new Dictionary<Planet, double>
                                                 {
                                                     { Planet.Earth, EarthYear },
                                                     { Planet.Mercury, 0.2408467 * EarthYear },
                                                     { Planet.Venus, 0.61519726 * EarthYear },
                                                     { Planet.Mars, 1.8808158 * EarthYear },
                                                     { Planet.Jupiter, 11.862615 * EarthYear },
                                                     { Planet.Saturn, 29.447498 * EarthYear },
                                                     { Planet.Uranus,84.016846 * EarthYear },
                                                     { Planet.Neptune, 164.79132 * EarthYear }
                                                 };

    public long Seconds { get; private set; }

    public SpaceAge(long secs)
    {
        Seconds = secs;
    }

    public double OnEarth()
    {
        return AgeHelper(Planet.Earth);
    }

    public double OnMercury()
    {
        return AgeHelper(Planet.Mercury);
    }

    public double OnVenus()
    {
        return AgeHelper(Planet.Venus);
    }

    public double OnMars()
    {
        return AgeHelper(Planet.Mars);
    }

    public double OnJupiter()
    {
        return AgeHelper(Planet.Jupiter);
    }

    public double OnSaturn()
    {
        return AgeHelper(Planet.Saturn);
    }

    public double OnUranus()
    {
        return AgeHelper(Planet.Uranus);
    }

    public double OnNeptune()
    {
        return AgeHelper(Planet.Neptune);
    }

    public double AgeHelper(Planet planet)
    {
        return Math.Round(Seconds / yearLenDict[planet], 2);
    }
}