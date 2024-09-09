using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Cooperativa
{
    public class Cliente : IComparable
    {
        public int DNI {  get; private set; }
        public string Nombre { get; private set; }
        public string Direccion {  get; private set; }
        public Medidor Medidor { get; private set; }

        public Cliente(string nombre, int dni, string direccion, Medidor medidor)
        { 
            this.Nombre = nombre;
            this.DNI = dni;
            this.Direccion = direccion;
            this.Medidor = medidor;
        }

        public int CompareTo(object obj)
        {
            int resultado = 1;
            Cliente c = obj as Cliente;
            if (c != null)
            {
                resultado = this.Medidor.NumeroServicio.CompareTo(c.Medidor.NumeroServicio);
            }
            return resultado;
        }

        public override string ToString()
        {
            return $@"{Nombre} ({DNI})";
        }
    }
}
