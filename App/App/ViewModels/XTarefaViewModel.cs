using App.DAL.TarefaDAL;
using App.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace App.ViewModels
{
  public class XTarefaViewModel
  {
    public XITarefaDAL TarefaDAL { get; set; }

    public Tarefa TarefaAtual { get; set; }
    public ObservableCollection<Tarefa> Tarefas { get; set; }
    public Command SalvarCommand { get; set; }
    public Command EditarCommand { get; set; }
    public Command AlterarEstadoCommand { get; set; }

    public XTarefaViewModel()
    {
      TarefaDAL = new XTarefaDAL();

      TarefaAtual = new Tarefa();
      Tarefas = new ObservableCollection<Tarefa>(TarefaDAL.GetTarefas());
      SalvarCommand = new Command(Salvar);
      EditarCommand = new Command(Editar);
      AlterarEstadoCommand = new Command(AlterarEstado);

    }

    private void Salvar()
    {
      TarefaAtual.Concluido = false;
      TarefaDAL.Salvar(TarefaAtual);
      Tarefas.Add(TarefaAtual);
      TarefaAtual = new Tarefa();
    }

    private void Editar()
    {

    }

    private void AlterarEstado()
    {
      if (TarefaAtual.Concluido)
        TarefaAtual.Concluido = false;
      else
        TarefaAtual.Concluido = true;
      TarefaDAL.Salvar(TarefaAtual);
    }

  }
}
