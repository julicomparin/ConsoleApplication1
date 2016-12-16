using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Agenda : IAgenda
    {
        IDictionary<DateTime,Calendario> iCalendarios = new SortedDictionary<DateTime,Calendario>();
        //implementacion de interfaz

        public void AgregarCalendario(Calendario pCalendario)
        {
            if (this.iCalendarios.ContainsKey(pCalendario.FechaCreacion))
            {
                throw new NullReferenceException("El Calendario Ya Existe");//si se produce la excepción, corta el flujo de ejecución
            }
            this.iCalendarios.Add(pCalendario.FechaCreacion,pCalendario);
        }

        public void ModificarCalendario(Calendario pCalendario)
        {
            if (!this.iCalendarios.ContainsKey(pCalendario.FechaCreacion))
            {
                throw new NullReferenceException("El Calendario No Existe");
            }
            this.iCalendarios.Add(pCalendario.FechaCreacion, pCalendario);
        }

        public void EliminarCalendario(string pCodigoCalendario)
        {
            if (!this.iCalendarios.ContainsKey(DateTime.Parse(pCodigoCalendario)))
            {
                throw new NullReferenceException("El Calendario No Existe");
            }

            this.iCalendarios.Remove(DateTime.Parse(pCodigoCalendario));
        }

        public IList<Calendario> ObtenerTodosCalendarios()
        {
            List<Calendario> mLista = new List<Calendario>(this.iCalendarios.Values);

            return mLista;
        }

        public Calendario ObtenerCalendarioPorCodigo(DateTime pCalendario)
        {
            if (!this.iCalendarios.ContainsKey(pCalendario))
            {
                throw new NullReferenceException();
            }

            return this.iCalendarios[pCalendario];
        }

        public IList<Calendario> ObtenerCalendariosOrdenadoPor(IComparer<Calendario> pComparadorCalendario)
        {
            List < Calendario > mLista = this.ObtenerTodosCalendarios().ToList();

            mLista.Sort(pComparadorCalendario);

            return mLista;
        }

        public IList<Evento> ObtenerEventosDeUnCalendario(Calendario pCalendario, IComparer<Evento> pComparador)
        {
            //crear clase para implemetar el pComparador
            IEnumerator<Calendario> mEnum = new List<Calendario>(this.iCalendarios.Values).GetEnumerator();
            while (mEnum.MoveNext())
            {
                if (mEnum.Current.Equals(pCalendario))
                return new List<Evento>(this.iCalendarios[pCalendario.FechaCreacion].ObtenerEventosOrdenadoPor(pComparador));
            }
            throw new NullReferenceException();
        }
    }
}
