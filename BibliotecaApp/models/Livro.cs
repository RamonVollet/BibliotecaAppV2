using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public int CategoriaId { get; set; }

        public List<Autor> Autores { get; set; } = new List<Autor>();
    }
}