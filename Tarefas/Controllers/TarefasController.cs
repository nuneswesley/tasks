using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Models;
using Tarefas.Services;

namespace Tarefas.Controllers
{
    public class TarefasController : Controller
    {
        ITarefaItemService _tarefaService;
        public TarefasController(ITarefaItemService tarefaService)
        {
            _tarefaService = tarefaService;
        }
        //Lista de tarefas
        public async Task<IActionResult> Index()
        {
            //obter intens da tarefa
            //TempTarefaItemService servico = new TempTarefaItemService();
            //var tarefas = servico.GetItemAsync();
            var tarefas = await _tarefaService.GetItemAsync();
            
            var model = new TarefaViewModel();
            {
                model.TarefaItens = tarefas;
            }

            return View(model);
        }
        
    }
}