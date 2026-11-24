using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Api.Models
{
public class Car
    {
    public int Id { get; set; }

    public string Brand { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string LicensePlate { get; set; } = string.Empty;
    
    public string Category { get ; set; } = "M8" ;

    public decimal DailyPrice { get; set; } //Price for day

    public int Year { get; set; } 

    public string Status { get; set; } = "Alquilado" ;
    }
}
