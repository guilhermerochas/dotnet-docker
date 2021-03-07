using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Rest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_Rest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationContext db;

        public PersonController(ApplicationContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> Get()
        {
            try
            {
                return await db.People.ToListAsync();
            }
            catch (Exception e)
            {
                return BadRequest($"Não foi possivel retornar as pessoas, motivo: {e}");
            }
        }
    }
}
