namespace PokedexAPI.Models.Pokemon;

public class HeldItem
{
	public Item item { get; set; }
	public List<VersionDetail> version_details { get; set; }
}
