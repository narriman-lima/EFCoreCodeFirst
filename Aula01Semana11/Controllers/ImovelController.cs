using Aula01Semana11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula01Semana11.Controllers
{
    [Route("api/imovel")]
    [ApiController]
    public class ImovelController : ControllerBase
    {
        private SqlContext _sqlContext { get; set; }

        public ImovelController(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        [HttpGet]
        public IEnumerable<Imovel> Get()
        {
            var listaImoveis = _sqlContext.Imoveis.ToList();
            return listaImoveis;
        }


        [HttpGet("{imovelId}")]
        public Imovel GetById([FromRoute] int imovelId)
        {
            var listaImoveis = _sqlContext.Imoveis.FirstOrDefault(x => x.Id == imovelId);
            return listaImoveis;
        }

        [HttpPost]
        public void Post([FromBody] Imovel imovel)
        {
            _sqlContext.Imoveis.Add(imovel);
            _sqlContext.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] Imovel imovel)
        {
            _sqlContext.Imoveis.Update(imovel);
            _sqlContext.SaveChanges();
        }

        [HttpDelete("{imovelId}")]
        public void Delete([FromRoute] int imovelId)
        {
            var imovelEncontrado = _sqlContext.Imoveis.FirstOrDefault(x => x.Id == imovelId);
            _sqlContext.Imoveis.Remove(imovelEncontrado);
            _sqlContext.SaveChanges();
        }
    }
}
