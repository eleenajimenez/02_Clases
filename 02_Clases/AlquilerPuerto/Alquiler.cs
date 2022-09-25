using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases.AlquilerPuerto
{
    class Alquiler
    {
        String nombre_cli;
        String dni_cli;
        DateTime fecha_inic;
        DateTime fecha_fin;
        String pos_amarre;
        Barco barco;
        int alquiler_barco;

        public Alquiler(string nombre_cli, string dni_cli, DateTime fecha_inic, DateTime fecha_fin, string pos_amarre, Barco barco)
        {
            this.nombre_cli = nombre_cli;
            this.dni_cli = dni_cli;
            this.fecha_inic = fecha_inic;
            this.fecha_fin = fecha_fin;
            this.pos_amarre = pos_amarre;
            this.barco = barco;
            this.alquiler_barco = alquiler(); 
        }

        public string Nombre
        {
            get { return nombre_cli; }
            set { nombre_cli = value; }
        }

        public string Dni
        {
            get { return dni_cli; }
            set { dni_cli = value; }
        }

        public DateTime Fecha_inic 
        {
            get { return fecha_inic; }
            set { fecha_inic = value; }
        }

        public DateTime Fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }

        public string Pos_amarre 
        {
            get { return pos_amarre; }
            set { pos_amarre = value; }
        }

        public Barco Barco 
        {
            get { return barco; }
            set { barco = value; }
        }

        public int Alquiler_barco
        {
            get { return alquiler_barco; }
            set { alquiler_barco = value; }
        }

        public int alquiler()
        {
            return this.barco.alquiler() * ((int)(Fecha_fin - Fecha_inic).TotalDays);
        }

        public override string? ToString()
        {
            return "Nombre del cliente: " + this.nombre_cli + "\n" +
                "Dni del cliente: " + this.dni_cli + "\n" +
                "Fecha de Inicio: " + this.fecha_inic.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")) + "\n" +
                "Fecha Final: " + this.fecha_fin.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")) + "\n" +
                "Matricula del barco alquilado: " +
                "" + this.barco.Matricula + "\n" +
                "Tipo de barco: " + this.barco.GetType().Name + " \n" +
                "Precio del alquiler: " + this.alquiler_barco + " euros" +
                "";
        }
    }
}
