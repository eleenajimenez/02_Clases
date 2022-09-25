using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases.AlquilerPuerto
{
    class Velero : Barco
    {
        private int mastiles;

        public int Mastiles
        {
            get { return mastiles; }
            set { mastiles = value; }
        }

        public Velero(int mastiles, string matricula, int fabricacion, int eslora) : base(matricula, eslora, fabricacion)
        {
            this.Matricula = matricula;
            this.Fabricacion = fabricacion;
            this.Eslora = eslora;
            this.mastiles = mastiles;
        }

        public override int alquiler()
        {
            return this.Eslora * 10 * 12 + mastiles;
        }
    }
}
