using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController : Controller
    {

        public static string CarregaLista(IEnumerable<Livro> livros)
        {
            var conteudoArquivo = HtmlUtils.CarregaArquivoHTML("para-ler");
            
            return conteudoArquivo.Replace("#NOVO-ITEM#", "");
        }

        public string Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(x => x.Id == id);
            return livro.Detalhes();
        }

        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();

            ViewBag.Livros = _repo.ParaLer.Livros;
            return View ("para-ler");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("para-ler");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("para-ler");
        }
    }
}
