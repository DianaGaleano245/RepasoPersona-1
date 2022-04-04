using System;

namespace RepasoPersona.Core 
{
    public class CuentaConSaldo
    {
        public double Saldo {get; set;}
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public double Efectivo { get; private set; }
        public Persona() => Efectivo = 0;
        public Persona(string nombre, string apellido, double efectivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Efectivo = efectivo;
        } 


        pepito.Debitar (debito);
        pepito.Acreditar(monto);
    }
}
