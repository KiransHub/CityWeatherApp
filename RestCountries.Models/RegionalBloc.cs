﻿using System.Collections.Generic;

namespace RestCountries.Models
{
    public class RegionalBloc
    {
        public string Acronym { get; set; }
        public string Name { get; set; }
        public List<object> OtherAcronyms { get; set; }
        public List<object> OtherNames { get; set; }
    }
}