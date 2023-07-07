using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PokedexAPI.Models.Pokemon;

namespace PokedexAPI.Controllers
{
	public class PokedexController : Controller
	{
		public IActionResult Pokedex()
		{
			var poke = new Root();
			return View(poke);
		}
	
		public IActionResult GetPoke(Root root)
		{
			try
			{
				var client = new HttpClient();
				var pokeURL = $"https://pokeapi.co/api/v2/pokemon/{root.name.ToLower()}";
				var pokeResponse = client.GetStringAsync(pokeURL).Result;
				var rootPoke = JsonConvert.DeserializeObject<Root>(pokeResponse);

				return View(rootPoke);
			}
			catch (Exception ex)
			{
				
				return View("Oops");

            }
		}


/*		public IActionResult GetAbility(Root root)
		{
			var client = new HttpClient();
			var URL = $"https://pokeapi.co/api/v2/ability/{root.id}";
			var response = client.GetStringAsync(URL).Result;
			var rootA = JsonConvert.DeserializeObject<Root>(response);

			return View(rootA);
		}*/
	}
}
