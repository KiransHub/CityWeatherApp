//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CityWeather.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    
    public partial class City
    {
        [Key]
		public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
        public short TouristRating { get; set; }
        public System.DateTime EstablishedDate { get; set; }
        public int EstimatedPopulation { get; set; }
    }
}
