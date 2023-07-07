using Newtonsoft.Json;

namespace PokedexAPI.Models.Pokemon;

public class Versions
{
	[JsonProperty("generation-i")]
	public GenerationI generationi { get; set; }

	[JsonProperty("generation-ii")]
	public GenerationIi generationii { get; set; }

	[JsonProperty("generation-iii")]
	public GenerationIii generationiii { get; set; }

	[JsonProperty("generation-iv")]
	public GenerationIv generationiv { get; set; }

	[JsonProperty("generation-v")]
	public GenerationV generationv { get; set; }

	[JsonProperty("generation-vi")]
	public GenerationVi generationvi { get; set; }

	[JsonProperty("generation-vii")]
	public GenerationVii generationvii { get; set; }

	[JsonProperty("generation-viii")]
	public GenerationViii generationviii { get; set; }
}
