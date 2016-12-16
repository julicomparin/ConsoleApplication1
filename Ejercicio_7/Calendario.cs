using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Calendario :IEventos,IComparable<Calendario>,IEquatable<Calendario>
    {
        //comparar calendios por fecha
        
        /*  metodo Parse()
            < fecha > "2/10/2007"
            < hora > "1:02:03 P.M."
            < desplazamiento > "-7:30:15"
        */
        private string iTitulo;
        private DateTime iFechaCreacion;
        private IList<Evento> iEventos;
        //-----------------------------------

        public int CompareTo(Calendario pCalendario)
        {
            return this.iFechaCreacion.ToString().CompareTo(pCalendario.iFechaCreacion.ToString());
        }

        public bool Equals(Calendario pCalendario)
        {
            return this.GetHashCode() == pCalendario.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.iFechaCreacion.ToString().GetHashCode();
        }

        //--------------constructor
        public Calendario(string pTitulo)
        {
            this.iFechaCreacion = DateTime.Now;
            this.iTitulo = pTitulo;
        }

        public string Titulo
        {
            get { return this.iTitulo; }
        }

        public DateTime FechaCreacion
        {
            get { return this.iFechaCreacion.Date; }
        }

        public TimeSpan HoraCreacion
        {
            get { return this.iFechaCreacion.TimeOfDay; }
        }

        //metodos de interfaz
        public void AgregarEvento(Evento pEvento)
        {
            if (this.iEventos.Contains(pEvento))
            {
                throw new NullReferenceException("El Evento Ya Existe");//si se produce la excepción, corta el flujo de ejecución
            }
            this.iEventos.Add(pEvento);
        }

        public void ModificarEvento(Evento pEvento)
        {
            if (!this.iEventos.Contains(pEvento))
            {
                throw new NullReferenceException("El Evento No Existe");
            }
            this.iEventos.Add(pEvento);
        }

        public void EliminarEvento(string pCodigoEvento)
        {
            if (this.ObtenerEventoPorCodigo(pCodigoEvento) == null)
            {
                throw new NullReferenceException("El Evento No Existe");
            }

            this.iEventos.Remove(ObtenerEventoPorCodigo(pCodigoEvento));
        }

        public IList<Evento> ObtenerTodosEventos()
        {
            return this.iEventos;
        }

        public Evento ObtenerEventoPorCodigo(string pEvento)
        {
            IEnumerator<Evento> mEnum = this.iEventos.GetEnumerator();
            while (mEnum.MoveNext())
            {
                if (mEnum.Current.Titulo == pEvento) return mEnum.Current;
            }
            throw new NullReferenceException();
        }

        public IList<Evento> ObtenerEventosOrdenadoPor(IComparer<Evento> pComparador)
        {
           List<Evento> mList = new List<Evento>(this.iEventos);
           mList.Sort(pComparador);
           return mList;
        }

        public IList<Evento> ObtenerEventosSegunCriterio(IComparer<Evento> pComparadorEvento)
        {
            throw new NotImplementedException();
        }
    }
}
