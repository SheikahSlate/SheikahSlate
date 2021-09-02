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
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Item> Get() => JsonSerializer.Deserialize<IEnumerable<Item>>(System.IO.File.ReadAllText("Items.json")) ?? Enumerable.Empty<Item>();
    }
}
