using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using AnalistaQualidadeTeste.Models;
using System;

namespace AnalistaQualidadeTeste.Controllers
{
    [Authorize]
    public class PaineisController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [AllowAnonymous]
        [Route("listar-painel")]
        public async Task<ActionResult> Index()
        {
            return View(await db.Paineis.ToListAsync());
        }

        [HttpGet]
        [Route("painel-detalhe/{id:int}")]
        public async Task<ActionResult> Details(int id)
        {
            var painel = await db.Paineis.FindAsync(id);

            if (painel == null)
            {
                return HttpNotFound();
            }
            return View(painel);
        }

        [HttpGet]
        [Route("novo-painel")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("novo-painel")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Titulo,Tipo,Prioridade,Descricao,NovaObservacao,Responsavel,Ativo")] Painel painel)
        {
            if (ModelState.IsValid)
            {
                painel.DataAbertura = DateTime.Now;
                db.Paineis.Add(painel);
                await db.SaveChangesAsync();

                TempData["Mensagem"] = "Tarefa cadastrada com sucesso!";

                return RedirectToAction("Index");
            }

            return View(painel);
        }

        [HttpGet]
        [Route("editar-painel/{id:int}")]
        public async Task<ActionResult> Edit(int id)
        {
            var painel = await db.Paineis.FindAsync(id);

            if (painel == null)
            {
                return HttpNotFound();
            }
            return View(painel);
        }

        [HttpPost]
        [Route("editar-painel/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Titulo,Tipo,Prioridade,Descricao,NovaObservacao,Responsavel,Ativo")] Painel painel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(painel).State = EntityState.Modified;

                db.Entry(painel).Property(a => a.DataAbertura).IsModified = false;

                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(painel);
        }

        [HttpGet]
        [Route("excluir-painel/{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var painel = await db.Paineis.FindAsync(id);

            if (painel == null)
            {
                return HttpNotFound();
            }
            return View(painel);
        }

        [HttpPost]
        [Route("excluir-painel/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var painel = await db.Paineis.FindAsync(id);
            db.Paineis.Remove(painel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
