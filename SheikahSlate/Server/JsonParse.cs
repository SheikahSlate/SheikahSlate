using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using SheikahSlate.Shared.Model;
using System.Collections.Generic;

public class JsonParse
{
	public IEnumerable<Item> ReadItems()
	{
		using var doc = JsonDocument.Parse(File.Open("Items.json"));


		return items;
	}
}
