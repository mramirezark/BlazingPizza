using BlazingPizza.Model;

namespace BlazingPizza.Services;

public interface IPizzaService
{
    Task<List<PizzaSpecial>> GetSpecials();
}