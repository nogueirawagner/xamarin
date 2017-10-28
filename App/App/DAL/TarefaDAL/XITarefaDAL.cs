using App.Models;
using System.Collections.Generic;

namespace App.DAL.TarefaDAL
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
