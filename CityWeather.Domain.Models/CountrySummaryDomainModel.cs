﻿using System.Collections.Generic;

namespace CityWeather.Domain.Models
{
    public class CountrySummaryDomainModel
    {
        public string Name { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string Capital { get; set; }
        public string NativeName { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public List<double> Latlng { get; set; }
        public List<string> CurrencyCodes { get; set; }
    }
}
