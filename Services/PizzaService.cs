using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;
public class PizzaService
{
     private readonly PizzaStoreContext _db;

     public PizzaService(PizzaStoreContext db)
    {
        _db = db;
    }
    public async Task<List<PizzaSpecial>> GetSpecials()
    {
       return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}