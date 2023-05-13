using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public static class PCMaker
    {
        
        public static List<Producto> productos = new List<Producto>();
        
        public static void Cargar()
        {
            productos = BaseDatos.CargarArchivoProductos();
        }
        private static string GeneradorId()
        {
            Random random = new Random();
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var clave = new char[16];

            for (int i = 0; i < clave.Length; i++)
            {
                clave[i] = caracteres[random.Next(caracteres.Length)];
            }

            string resultado = new string(clave);

            return resultado;
        }
    }
}
