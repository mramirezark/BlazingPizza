using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingPizza.Data;

namespace BlazingPizza.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
    //private readonly PizzaStoreContext _db;
    private readonly PizzaService _pizzaService;

    public SpecialsController(PizzaService pizzaService)
    {
        //_db = db;
        _pizzaService = pizzaService;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
       var result =   await _pizzaService.GetSpecials();
       return result;
        //return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}