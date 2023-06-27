using LibClases;

namespace LibClases_Test
{
    [TestClass]
    public class PCMakerShould
    {
        [TestMethod]
        public void BuscarPresupuestoCorrectamente()
        {
            string id = "5";

            Presupuesto presupuestoEsperado = PCMaker.BuscarPresupuesto(id);

            Assert.IsNotNull(presupuestoEsperado);
            Assert.AreEqual(id, presupuestoEsperado.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void BuscarPresupuestoNullOrEmptyId()
        {
            string id = null!; 

            
            Presupuesto result = PCMaker.BuscarPresupuesto(id);
        }

        private string TestFileName = "test_file";

        [TestMethod]
        public void ExportarCSVListaVaciaNoCreaArchivo()
        {
            List<string> lista = new List<string>(); 

            PCMaker.ExportarCSV(TestFileName, lista); 

            Assert.IsFalse(File.Exists(TestFileName + ".csv")); 
        }

        [TestMethod]
        public void ExportarCSVListaStringsCreaArchivoCorrecto()
        {
            List<string> lista = new List<string> { "AAA", "BBB", "CCCC" };

            PCMaker.ExportarCSV(TestFileName, lista); 

            Assert.IsTrue(File.Exists(TestFileName + ".csv")); 

            File.Delete(TestFileName + ".csv");
        }

        [TestMethod]
        public void ExportarCSVListaCreaArchivoCorrecto()
        {
            List<Usuario> lista = new List<Usuario>();
        
            lista.Add(new("qqqq", "qqq", "qqq", "qqq", ERoles.Empleado, "qqq"));
            lista.Add(new("aaa", "aaa", "aaa", "aaa", ERoles.Empleado, "aaa"));
        
            PCMaker.ExportarCSV(TestFileName, lista); 

            Assert.IsTrue(File.Exists(TestFileName + ".csv"));

            File.Delete(TestFileName + ".csv");
        }
    }
}
