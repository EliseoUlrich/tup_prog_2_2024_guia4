using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Cooperativa
{
    public class Medidor
    {
        public int NumeroServicio { get; private set; }
        public double LecturaAnterior { get; private set; }
        public double LecturaActual { get; private set; }

        ArrayList consumos = new ArrayList();
        public int CantidadConsumos { get {return consumos.Count;} }
        private int periodoActual;
        public int PeriodoActual
        {
            get { return periodoActual; }
            private set
            {
                if (CantidadConsumos == 8)
                    consumos.RemoveAt(0);
                periodoActual = value % 6;
            }
        }

        public Medidor(int numeroServicio)
        {
            this.NumeroServicio = numeroServicio;
        }
        public double ConsumoActual()
        {
            return LecturaActual - LecturaAnterior;
        }
        public void Medicion(double lectura)
        {
            LecturaAnterior = LecturaActual;
            LecturaActual = lectura;
        }

        public void RegistrarConsumo(double medicion)
        {
            PeriodoActual++;
            LecturaActual = medicion;
            consumos.Add(ConsumoActual());
        }

        public double LeerConsumo(int pos)
        {
            return (double)consumos[pos];
        }
    }
}
