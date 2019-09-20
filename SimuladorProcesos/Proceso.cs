using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorProcesos
{
    public class Proceso
    {

        public string Nombre { get; set; }
        public int Id { get; set; }
        public int Tiempo { get; set; }
        public int IO { get; set; }
        public string Estado { get; set; }
        public int Quantum { get; set; }
        public int TiempoRestante { get; set; }

        public Proceso(int id, string nombre, int tiempo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Estado = "NEW";
            this.Tiempo = tiempo;
            this.IO = 0;
            this.TiempoRestante = 0;
        }

    }
}
