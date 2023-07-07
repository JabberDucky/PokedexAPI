using Newtonsoft.Json;

namespace PokedexAPI.Models.Pokemon;

public class GenerationVii
{
	public Icons icons { get; set; }

	[JsonProperty("ultra-sun-ultra-moon")]
	public UltraSunUltraMoon ultrasunultramoon { get; set; }
}
