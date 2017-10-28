using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.MapeamentoRelacional.TarefaDAL
{
  public interface XITarefaDAL
  {
    List<Tarefa> GetTarefas();
    Tarefa GetTarefaID(int pID);
    int Salvar(Tarefa pTarefa);
    int Alterar(Tarefa pTarefa);
    int Excluir(Tarefa pTarefa);
  }
}
