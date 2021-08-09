using Back_end.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Back_end.Controllers
{
    // default attribute routing with controller name and methods (actions)
    [Route("[controller]/[action]")]
    public class BaseController : Controller
    {
        // for inheritance
        protected airecommerceContext _dbContext;

        public BaseController(airecommerceContext context)
        {
            _dbContext = context;
        }

    }
}
