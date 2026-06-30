using MaquinaCafe.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Tests
{
    [TestFixture]
    public class TestAzucarero
    {
        [Test]
        public void DeberiaDevolverVerdaderoSiExisteAzucar()
        {
            Azucarero azucarero = new Azucarero(20);

            bool resultado = azucarero.HasAzucar(5);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void DeberiaDevolverFalsoSiNoExisteAzucar()
        {
            Azucarero azucarero = new Azucarero(2);

            bool resultado = azucarero.HasAzucar(5);

            Assert.IsFalse(resultado);
        }

        [Test]
        public void DeberiaRestarCantidadDeAzucar()
        {
            Azucarero azucarero = new Azucarero(20);

            azucarero.GiveAzucar(5);

            Assert.AreEqual(15, azucarero.GetCantidadDeAzucar());
        }
    }
}

