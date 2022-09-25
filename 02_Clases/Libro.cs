using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public class Libro
    {
        string str_titulo;
        string str_autor;
        string str_estilo;
        string str_editorial;

        public string Titulo
        {
            get { return str_titulo; }
            set { str_titulo = value; }
        }

        public string Autor
        {
            get { return str_autor; }
            set { str_autor = value; }
        }

        public string Estilo
        {
            get { return str_estilo; }
            set { str_estilo = value; }
        }

        public string Editorial
        {
            get { return str_editorial; }
            set { str_editorial = value; }
        }


        public Libro(string titulo, string autor, string estilo, string editorial)
        {
            this.str_titulo = titulo;
            this.str_autor = autor;
            this.str_estilo = estilo;
            this.str_editorial = editorial;
        }

        public override string ToString()
        {
            return base.ToString(); 
        }

        

    }
}
