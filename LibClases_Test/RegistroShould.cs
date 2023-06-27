using LibClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases_Test
{
    [TestClass]
    public class RegistroShould
    {

        [TestMethod]
        public void ConfirmarUsuarioCorrectamente()
        {
            string userTest = "admin";
            string passTest = "admin";

            bool usuarioEsperado = Registro.ConfirmarUsuario(userTest,passTest);

            Assert.IsTrue(usuarioEsperado);
            
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ConfirmarUsuarioVacio()
        {
            string userTest = "qwe";
            string passTest = "qwe";

            bool usuarioEsperado = Registro.ConfirmarUsuario(userTest, passTest);

            Assert.IsTrue(usuarioEsperado);

        }


    }
}
