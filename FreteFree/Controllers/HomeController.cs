using FreteFree.Data;
using FreteFree.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FreteFree.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}


        private readonly FreteFreeContext _context;

        public HomeController(FreteFreeContext context)
        {
            _context = context;
        }

        // GET: OrdemCarregamento
        public async Task<IActionResult> Index()
        {
            var freteFreeContext = _context.OrdemCarregamento.Include(o => o.Empresa);
            return View(await freteFreeContext.ToListAsync());
        }

        // GET: OrdemCarregamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemCarregamento = await _context.OrdemCarregamento
                .Include(o => o.Empresa)
                .Include(o => o.Motorista)
                .FirstOrDefaultAsync(m => m.OrdemCarregamentoId == id);
            if (ordemCarregamento == null)
            {
                return NotFound();
            }

            return View(ordemCarregamento);
        }
        public async Task<IActionResult> Impressao(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemCarregamento = await _context.OrdemCarregamento
                .Include(o => o.Empresa)
                .Include(o => o.Motorista)
                .FirstOrDefaultAsync(m => m.OrdemCarregamentoId == id);
            if (ordemCarregamento == null)
            {
                return NotFound();
            }

            return View(ordemCarregamento);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
