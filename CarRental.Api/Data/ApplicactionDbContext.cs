using CarRental.Api.Models;

namespace CarRental.Api.Data;

public static class ApplicationDbContext
{
    public static List<User> Users { get; set; } = new()
    {

        new User { Id = 1, Username = "Aministrador", Email = "alexandercrak031@gmail.com", Password = "123", Role = "Admin" },
        new User { Id = 2, Username = "Trabajador", Email = "insanoo@gmail.com", Password = "456", Role = "Trabajador" },

    };
    public static List<Car> Cars { get; set; } = new()
    {

    new Car { Id = 1, Brand = "Chevrolet", Model = "Camaro", LicensePlate = "PWM-165", Category = "Coupés", Year = 2024, DailyPrice = 95, Status = "Disponible" },
    new Car { Id = 2, Brand = "Nissan", Model = "Z", LicensePlate = "CTV-254", Category = "Coupés", Year = 2025, DailyPrice = 85, Status = "Disponible" },
    new Car { Id = 3, Brand = "Ferrari", Model = "296 GTB", LicensePlate = "CMN-555", Category = "Coupés", Year = 2023, DailyPrice = 70, Status = "Alquilado" }
  
  };
  public static List<Rental> Rentals { get; set; } = new();

}