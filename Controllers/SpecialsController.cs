using BlazingPizza.Model;
using BlazingPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazingPizza.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController(IPizzaService pizzaService) : Controller
{
    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        var result = await pizzaService.GetSpecials();
        return result;
    }
}