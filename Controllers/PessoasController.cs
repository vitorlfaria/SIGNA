using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIGNA.Data;
using SIGNA.Models;
using SIGNA.Utils;

namespace SIGNA.Controllers
{
    public class PessoasController : Controller
    {
        private SignaDBContext _context { get; set; }
        private readonly FormatCPForCNPJ formatCPForCNPJ = new();

        public PessoasController(SignaDBContext context)
        {
            _context = context;
        }

        public ActionResult Index(string? success)
        {
            List<Pessoa> pessoas = new();

            if(success != null)
            {
                ViewBag.Success = success;
            }

            return View(pessoas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(IFormCollection collection)
        {
            List<Pessoa> pessoas = await _context.Pessoas.ToListAsync();

            return View(pessoas);
        }

        // GET: PessoasController/Detalhes/5
        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pessoa? pessoa = await _context.Pessoas.FirstOrDefaultAsync(p => p.PESSOA_ID == id);

            if (pessoa == null)
            {
                return NotFound();
            }

            pessoa.CNPJ_CPF = formatCPForCNPJ.Format(pessoa.CNPJ_CPF);

            return View(pessoa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detalhes(int id, Pessoa pessoa)
        {
            try
            {
                Pessoa pessoaDB = await _context.Pessoas.FirstOrDefaultAsync(p => p.PESSOA_ID == id);
                pessoaDB.NOME_FANTASIA = pessoa.NOME_FANTASIA;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { success = "true" });
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}
