﻿using Newtonsoft.Json;
namespace AspNetMVC.Models
{
    public class WeatherModel
    {
        public string City { get; set; }
        public double Temperature { get; set; }
        public string WeatherDescription { get; set; }
        public string Weather { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
    }
}
