using System;
using System.Collections.Generic;
using System.Linq;
using TempoClima.Context;
using TempoClima.Models;

namespace TempoClima.Repositorio
{
    public class PrevisaoClimaRepositorio
    {
        private readonly BaseContext _baseContext;
        public PrevisaoClimaRepositorio()
        {
            _baseContext = new BaseContext();
        }
        public List<PrevisaoClima> MenoresTemperaturas()
        {
            return _baseContext.PrevisoesClima.OrderBy(s => s.TemperaturaMinima).Take(2).ToList();
        }

        public List<PrevisaoClima> MaioresTemperaturas()
        {
            return _baseContext.PrevisoesClima.OrderByDescending(s => s.TemperaturaMaxima).Take(2).ToList();
        }

        public List<PrevisaoClima> PrevisoesPorCidade(int idCidade)
        {
            return _baseContext.PrevisoesClima.Where(s => s.CidadeId == idCidade && s.DataPrevisao > DateTime.Now).OrderBy(s => s.DataPrevisao).Take(7).ToList();
        }
    }
}