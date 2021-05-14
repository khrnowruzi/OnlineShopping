using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopping.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoodsController : ControllerBase
    {
        private readonly ILogger<GoodsController> _logger;

        public GoodsController(ILogger<GoodsController> logger)
        {
            _logger = logger;
        }
    }
}
