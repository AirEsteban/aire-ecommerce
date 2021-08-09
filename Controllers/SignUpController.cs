using Back_end.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_end.Controllers
{
    public class SignUpController : BaseController
    {
        public SignUpController(airecommerceContext context) : base(context)
        {

        }

        [NonAction]
        public Microsoft.EntityFrameworkCore.DbContextId Hola()
        {
            return _dbContext.ContextId;
        }
        
    }
}
