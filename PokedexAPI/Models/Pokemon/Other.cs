using Newtonsoft.Json;

namespace PokedexAPI.Models.Pokemon;

public class Other
{
	public DreamWorld dream_world { get; set; }
	public Home home { get; set; }

	[JsonProperty("official-artwork")]
	public OfficialArtwork officialartwork { get; set; }
}
