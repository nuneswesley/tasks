using Microsoft.AspNetCore.Mvc;

namespace Tarefas.Controllers
{
    public class TarefasController : Controller
    {
        //Lista de tarefas
        public IActionResult Index()
        {
            //obter os dados retornar
            return View();
        }
        
    }
}