using Newtonsoft.Json;

namespace PokedexAPI.Models.Pokemon;

public class GenerationVi
{
	[JsonProperty("omegaruby-alphasapphire")]
	public OmegarubyAlphasapphire omegarubyalphasapphire { get; set; }

	[JsonProperty("x-y")]
	public XY xy { get; set; }
}
