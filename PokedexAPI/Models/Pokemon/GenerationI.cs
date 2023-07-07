using Newtonsoft.Json;

namespace PokedexAPI.Models.Pokemon;

public class GenerationI
{
	[JsonProperty("red-blue")]
	public RedBlue redblue { get; set; }
	public Yellow yellow { get; set; }
}
