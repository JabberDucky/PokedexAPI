﻿namespace PokedexAPI.Models.Pokemon;

public class Stat
{
	public int base_stat { get; set; }
	public int effort { get; set; }
	public Stat stat { get; set; }
}
