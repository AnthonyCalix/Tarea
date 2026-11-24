using Microsoft.AspNetCore.Mvc;
using CarRental.Api.Data;
using CarRental.Api.Models;

namespace CarRental.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CarsController : ControllerBase

{
  [HttpGet]
  public ActionResult<IEnumerable<Car>> GetAll()
  {
    return Ok(ApplicationDbContext.Cars);
  }

  [HttpGet("{id:int}")]
  public ActionResult<Car> GetById(int id)
  {
    var car = ApplicationDbContext.Cars.FirstOrDefault(c => c.Id == id);
    if (car is null) return NotFound(new { message = "Auto no encontrado." });
    return Ok(car);
  }

  [HttpPost]
  public ActionResult<Car> Create(Car newCar)

  {
    var nextId = ApplicationDbContext.Cars.Count > 0 ? ApplicationDbContext.Cars.Max(c => c.Id) + 1 : 1;
    newCar.Id = nextId;
    if (string.IsNullOrWhiteSpace(newCar.Status))
      newCar.Status = "Disponible";
    ApplicationDbContext.Cars.Add(newCar);
    return CreatedAtAction(nameof(GetById), new { id = newCar.Id }, newCar);
  }

  [HttpPut("{id:int}")]
  public IActionResult Update(int id, Car updatedCar)
  {
    var car = ApplicationDbContext.Cars.FirstOrDefault(c => c.Id == id);
    if (car is null) return NotFound(new { message = "Auto no encontrado." });

    car.Brand = updatedCar.Brand;
    car.Model = updatedCar.Model;
    car.LicensePlate = updatedCar.LicensePlate;
    car.Category = updatedCar.Category;
    car.Year = updatedCar.Year;
    car.DailyPrice = updatedCar.DailyPrice;
    car.Status = updatedCar.Status;
    return Ok(car);
  }

  [HttpDelete("{id:int}")]
  public IActionResult Delete(int id)
  {
    var car = ApplicationDbContext.Cars.FirstOrDefault(c => c.Id == id);
    if (car is null) return NotFound(new { message = "Auto no encontrado." });

    ApplicationDbContext.Cars.Remove(car);
    return NoContent();
  }

}