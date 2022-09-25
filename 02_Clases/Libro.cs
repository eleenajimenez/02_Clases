using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public class Libro
    {
        private String titulo;
        private String autor;
        private String estilo;
        private String editorial;

        public Libro(string titulo, string autor, string estilo, string editorial)
        {
            Titulo = titulo;
            Autor = autor;
            Estilo = estilo;
            Editorial = editorial;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }


        

        public override string ToString()
        {
            return string.Format("Titulo: " + this.titulo + "\t Autor: " + this.autor + "\t Estilo: " + this.estilo + "\t Editorial: " + this.editorial);
        }

        

    }
}
