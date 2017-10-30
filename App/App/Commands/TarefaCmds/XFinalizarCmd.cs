using App.DAL.TarefaDAL;
using App.Models;
using App.ViewModels;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace App.Commands.TarefaCmds
{
  public class XFinalizarCmd : XTarefaCmdBase
  {
    public XFinalizarCmd(XTarefaViewModel pTelaVM)
    {
      TarefaDAL = new XTarefaDAL();
      TelaVM = pTelaVM;
    }

    public override void Execute(object pParameter)
    {
      var tarefa = (Tarefa)pParameter;
      if (tarefa.Concluido)
        tarefa.Concluido = false;
      else
        tarefa.Concluido = true;

      TarefaDAL.Alterar(tarefa);
      AtualizarLista();
    }
  }
}
