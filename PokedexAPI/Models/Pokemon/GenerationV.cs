using Newtonsoft.Json;

namespace PokedexAPI.Models.Pokemon;

public class GenerationV
{
	[JsonProperty("black-white")]
	public BlackWhite blackwhite { get; set; }
}
