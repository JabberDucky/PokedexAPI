using Newtonsoft.Json;

namespace PokedexAPI.Models.Pokemon;

public class GenerationIv
{
	[JsonProperty("diamond-pearl")]
	public DiamondPearl diamondpearl { get; set; }

	[JsonProperty("heartgold-soulsilver")]
	public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }
	public Platinum platinum { get; set; }
}
