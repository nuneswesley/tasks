using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services
{
    public class TempTarefaItemService :ITarefaItemService
    {
        public Task<IEnumerable<TarefaItem>> GetItemAsync()
        {
            //Retorna um array de intens tarefas
            IEnumerable<TarefaItem> items = new[]
            {
                new TarefaItem
                {
                    Nome = "Aprender ASPN.NET CORE 2.0",
                    EstaCompleta = false,
                    DataConclusao = DateTimeOffset.Now.AddDays(30)
                },

                new TarefaItem
                {
                    Nome = "Criar Aplicações Web",
                    EstaCompleta = false,
                    DataConclusao = DateTimeOffset.Now.AddDays(60)
                }
            
            };
            return Task.FromResult(items);               
        }
            
    }
}