using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class Venta
    {

        private string _presupuestoId;
        private string _cliente;
        private string _tarjetaNumero;
        private string _cuotas;
        private string _ganancia;
        private string _usuario;

        public Venta(string presupuestoId, string cliente, string tarjetaNumero, string cuotas, string ganancia, string usuario)
        {
            _presupuestoId = presupuestoId;
            _cliente = cliente;
            _tarjetaNumero = tarjetaNumero;
            _cuotas = cuotas;
            _ganancia = ganancia;
            _usuario = usuario;
        }

        public string PresupuestoId { get => _presupuestoId; }
        public string Cliente { get => _cliente; }
        public string TarjetaNumero { get => _tarjetaNumero; }
        public string Cuotas { get => _cuotas; }
        public string Ganancia { get => _ganancia; }
        public string Usuario { get => _usuario; }

        public override string ToString()
        {
            return $"{PresupuestoId},{Cliente},{TarjetaNumero},{Cuotas},{Ganancia},{Usuario}";
        }

    }
}
