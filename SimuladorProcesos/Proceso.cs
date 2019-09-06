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
        private int tiempoLlegada;
        private int duracion;

        public Proceso(int id, string nombre, Estado estado, int tiempoLlegada, int duracion)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;
            this.tiempoLlegada = tiempoLlegada;
            this.duracion = duracion;
        }

        public enum Estado
        {
            NUEVO,
            LISTO,
            EJECUCION,
            BLOQUEADO,
            TERMIANDO
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEstado(Estado estado)
        {
            this.estado = estado;
        }

        public void setTiempoLlegada(int tiempoLlegada)
        {
            this.tiempoLlegada = tiempoLlegada;
        }

        public void setDuracion(int duracion)
        {
            this.duracion = duracion;
        }

        public int getId()
        {
            return this.id;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public Estado getEstado()
        {
            return this.estado;
        }

        public int getTiempoLlegada()
        {
            return this.tiempoLlegada;
        }

        public int getDuracion()
        {
            return this.duracion;
        }

    }
}
