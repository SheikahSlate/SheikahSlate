using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SheikahSlate.Shared;
using SheikahSlate.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheikahSlate.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {

        private readonly ILogger<ItemsController> _logger;

        public ItemsController(ILogger<ItemsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Item> Get() => JsonParse.ReadItems();
    }
}
