using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HTTPMetodeController: ControllerBase
    {
        [HttpGet]
        public string Pozdravi()
        {
            return "Hello";
        }


        [HttpGet]
        [Route("pozdrav")]
        public string Pozdravi(string s)
        {
            return "Hello " + s;
        }


        [HttpGet]
        [Route("hello")]
        public IActionResult Pozdravi(int id, string ime)
        {
            return Ok(new {sifra=id,naziv=ime});
        }


        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest("Nešto ne valja");
        }


        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            osoba.Ime = osoba.Ime + " promjenio";

            Response.StatusCode = StatusCodes.Status202Accepted;
            return new JsonResult(osoba);
        }


        [HttpDelete]
        public IActionResult Delete(int d)
        {
            return NotFound("Nije pronađeno u bazi");
        }


    }
}
