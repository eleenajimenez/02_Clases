using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases.AlquilerPuerto
{
    class Yate : EmbDeportiva
    {
        private int camarotes;

        public int Camarotes
        {
            get { return camarotes; }
            set { camarotes = value; }
        }

        public Yate(string matricula, int fabricacion, int eslora, int potencia, int camarotes) : base(potencia, matricula, fabricacion, eslora)
        {
            this.Matricula = matricula;
            this.Fabricacion = fabricacion;
            this.Eslora = eslora;
            this.Potencia = potencia;
            this.camarotes = camarotes;
        }
        public override int alquiler()
        {
            return this.Eslora * 10 * 12 + this.Potencia + this.camarotes;
        }
    }
}
