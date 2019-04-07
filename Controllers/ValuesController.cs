using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API.Model;

namespace ProAgil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] {
                new Evento(){
                    EventoId= 1,
                    Local= "Salvador",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Tema= "ReactJS",
                    QtdPessoas=250,
                    Lote="1º Lote"
                },
                new Evento(){
                    EventoId= 2,
                    Local= "Blumenau",
                    DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                    Tema= "Angular 7",
                    QtdPessoas=100,
                    Lote="2º Lote"
                }
             };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[] {
                new Evento(){
                    EventoId= 1,
                    Local= "Salvador",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Tema= "ReactJS",
                    QtdPessoas=250,
                    Lote="1º Lote"
                },
                new Evento(){
                    EventoId= 2,
                    Local= "Blumenau",
                    DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                    Tema= "Angular 7",
                    QtdPessoas=100,
                    Lote="2º Lote"
                }
             }.FirstOrDefault(x => x.EventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
