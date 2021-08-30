using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SheikahSlate.Shared;
using SheikahSlate.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SheikahSlate.Server.Controllers
{
    [ApiController]
    [Route("/Api/[controller]")]
    public class DungeonsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Dungeon> Get() { 
            List<Dungeon> dungeons = JsonSerializer.Deserialize<IEnumerable<Dungeon>>(System.IO.File.ReadAllText("Dungeons.json")).ToList();
            return dungeons;
        }
    }
}
