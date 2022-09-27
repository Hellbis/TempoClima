using System.Web.Mvc;
using TempoClima.Repositorio;

namespace TempoClima.Controllers
{
    public class HomeController : Controller
    {
        private readonly PrevisaoClimaRepositorio _previsaoClimaRepositorio;
        private readonly CidadeRepositorio _cidadeRepositorio;
        public HomeController()
        {
            _previsaoClimaRepositorio = new PrevisaoClimaRepositorio();
            _cidadeRepositorio = new CidadeRepositorio();
        }
        public ActionResult Index()
        {
            ViewBag.TemperaturasMinimas = _previsaoClimaRepositorio.MenoresTemperaturas();
            ViewBag.TemperaturasMaximas = _previsaoClimaRepositorio.MaioresTemperaturas();
            return View(_cidadeRepositorio.Listar());
        }

        public ActionResult Sobre()
        {
            return View();
        }

        [Route("{id}")]
        [HttpPost]
        public ActionResult PrevisaoDias(int id)
        {
            return Json(_previsaoClimaRepositorio.PrevisoesPorCidade(id));
        }
    }
}