using BlazingPizza.Data;
using BlazingPizza.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Services;
public class PizzaService(PizzaStoreContext db) : IPizzaService
{
    public async Task<List<PizzaSpecial>> GetSpecials()
    {
       return (await db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}