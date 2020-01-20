using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using WebApplication1.Models;
using System.IO;
using System.Text;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController : ControllerBase
    {


        private readonly ILogger<ExpenseController> _logger;

        public ExpenseController(ILogger<ExpenseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public object Get()
        {
            var items = new[]
                {
                    new {id = "1" , name = "Cable"},
                    new {id = "2" , name= "Movies"},
                    new {id = "3" , name= "Utility"},
                };
            
            return items;
        }
    } 
}



