using System.Collections.Generic;
using System.Linq;
using TempoClima.Context;
using TempoClima.Models;

namespace TempoClima.Repositorio
{
    public class CidadeRepositorio
    {
        private readonly BaseContext _baseContext;
        public CidadeRepositorio()
        {
            _baseContext = new BaseContext();
        }
        public List<Cidade> Listar()
        {
            return _baseContext.Cidades.OrderBy(s => s.Nome).ToList();
        }
    }
}