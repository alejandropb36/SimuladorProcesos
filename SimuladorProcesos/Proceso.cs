using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorProcesos
{
    class Proceso
    {
        private int id;
        private string nombre;
        private Estado estado;

        public Proceso(int id, string nombre, Estado estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;
        }

        public enum Estado
        {
            Terminado = -1,
            Listo,
            Ejecutandose,
            Bloqueado
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEstado(Estado estado)
        {
            this.estado = estado;
        }

        public int getId()
        {
            return this.id;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getEstado()
        {
            string resultado = "";
            switch (estado)
            {
                case Estado.Terminado:
                    resultado = "Terminado";
                    break;
                case Estado.Listo:
                    resultado = "Listo";
                    break;
                case Estado.Ejecutandose:
                    resultado = "Ejecutandose";
                    break;
                case Estado.Bloqueado:
                    resultado = "Bloqueado";
                    break;
                default:
                    resultado = "Error";
                    break;
            }
            return resultado;
        }


    }
}
