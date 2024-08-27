using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Bruno Henrique", "Bruno.lindo@gmail.com", 696969);
            Aluno a2 = new Aluno(2, "Thiago Mazzi", "Mazzi.lindo@gmail.com", 348934);
            Aluno a3 = new Aluno(3, "Ryan", "Ryan.lindo@gmail.com", 775533);
            Aluno a4 = new Aluno(4, "Jones", "Jones.lindo@gmail.com", 990077);
            Aluno a5 = new Aluno(5, "Bryan", "Rato.lindo@gmail.com", 326946);

            //Criar uma lista de Alunos
            List<Aluno> ListaAlunos = new List<Aluno>();
            //Adicionar os objetos Alunos na lista
            ListaAlunos.Add(a1);
            ListaAlunos.Add(a2);
            ListaAlunos.Add(a3);
            ListaAlunos.Add(a4);
            ListaAlunos.Add(a5);
            // Enviando a Lista de Alunos´por parametro na view Index
            return View(ListaAlunos);
        }
        public IActionResult Cadastrar() { return View(); }
    }
}