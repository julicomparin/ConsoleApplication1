using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Evento:IComparable<Evento>
    {
        private string iTitulo;
        private TimeSpan iFechaComienzo;
        private TimeSpan iHoraComienzo;
        private int iDuracion;
        private Frecuencia iFrecuencia;

        public Evento(string pTitulo, TimeSpan pFechaComienzo, TimeSpan pHoraComienzo, int pDuracion, Frecuencia pFrecuencia)
        {
            this.iFechaComienzo = pFechaComienzo;
            this.iTitulo = pTitulo;
            this.iHoraComienzo = pHoraComienzo;
            this.iDuracion = pDuracion;
            this.iFrecuencia = pFrecuencia;
        }

        public string Titulo
        {
            get { return this.iTitulo; }
        }

        public string FechaCreacion
        {
            get { return this.iFechaComienzo.ToString(); }
        }

        public string HoraCreacion
        {
            get { return this.iHoraComienzo.ToString(); }
        }

        public int CompareTo(Evento pEvento)
        {
            return this.iTitulo.CompareTo(pEvento.iTitulo);
        }

        public bool Equals(Evento pEvento)
        {
            return this.GetHashCode() == pEvento.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.iTitulo.GetHashCode();
        }
    }
}
