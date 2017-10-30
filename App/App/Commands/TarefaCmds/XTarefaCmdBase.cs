using App.ViewModels;
using System;
using System.Windows.Input;
using App.Models;
using App.DAL.TarefaDAL;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App.Commands.TarefaCmds
{
  public class XTarefaCmdBase : ICommand
  {
    public XITarefaDAL TarefaDAL { get; set; }

    public event EventHandler CanExecuteChanged;

    public XTarefaViewModel TelaVM { get; set; }
    public Tarefa Tarefa { get; set; }

    public virtual bool CanExecute(object pParameter)
    {
      pParameter = true;
      return (bool)pParameter;
    }

    public virtual void Execute(object pParameter)
    {
    }

    public void AtualizarLista()
    {
      TelaVM.Tarefas = new ObservableCollection<Tarefa>(TarefaDAL.GetTarefas());
      TelaVM.OnPropertyChanged("Tarefas");
    }


  }
}
