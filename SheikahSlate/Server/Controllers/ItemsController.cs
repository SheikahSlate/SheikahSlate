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
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {

        private readonly ILogger<ItemsController> logger;

        public ItemsController(ILogger<ItemsController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Item> Get() => JsonSerializer.Deserialize<IEnumerable<Item>>(System.IO.File.ReadAllText("Items.json"));
    }
}
