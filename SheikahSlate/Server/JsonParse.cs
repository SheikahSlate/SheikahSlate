using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using SheikahSlate.Shared.Model;
using System.Collections.Generic;
using System.IO;

namespace SheikahSlate.Server
{
    public class JsonParse
    {
        public static IEnumerable<Item> ReadItems()
        {
            IEnumerable<Item> items = JsonSerializer.Deserialize<IEnumerable<Item>>(File.ReadAllText("Items.json"));

            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }

            return items;
        }
    }
}
