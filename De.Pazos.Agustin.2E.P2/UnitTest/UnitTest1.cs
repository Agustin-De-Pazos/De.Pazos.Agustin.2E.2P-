using System.Runtime.Intrinsics.X86;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_ValidarUsuario_DeberiaRetornarFalseSiNoExiste()
        {
            // arrage - act - addert

            //arrage
            string gmail = "carlos@gmail.com";
            string apellido = "landini";
            int dni = 1231242444;

            // Act -> llamada a la funcionalidad a testiar
            bool todoOk = true;
            todoOk = Dao.ValidarUsuario(gmail, apellido, dni);//RETORNA FALSE SI NO EXISTE

            //Assert -> comprobacion de resultados
            Assert.IsFalse(todoOk);
        }
        [TestMethod]
        public void Test_ValidarUsuario_DeberiaRetornarTrueSiExiste()
        {
            // arrage - act - addert

            //arrage
            string gmail = "depazosagustin@gmail.com";
            string apellido = "de pazos";
            int dni = 412312;

            // Act -> llamada a la funcionalidad a testiar
            bool todoOk = false;
            todoOk = Dao.ValidarUsuario(gmail, apellido, dni);//RETORNA FALSE SI NO EXISTE

            //Assert -> comprobacion de resultados
            Assert.IsTrue(todoOk);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ValidarUsuario_ThrowArgumentException_ValoresNULL()
        {
            string gmail = "";
            string apellido = "";
            int dni = 143456;

            _ = Dao.ValidarUsuario(gmail, apellido, dni);
        }
    }
}