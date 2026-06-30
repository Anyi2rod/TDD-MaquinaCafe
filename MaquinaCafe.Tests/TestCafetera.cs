using MaquinaCafe.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Tests
{
    [TestFixture]
    public class TestCafetera
    {
        [Test]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(100);

            bool resultado = cafetera.HasCafe(50);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(20);

            Assert.IsFalse(resultado);
        }

        [Test]
        public void DeberiaRestarCantidadDeCafe()
        {
            Cafetera cafetera = new Cafetera(100);

            cafetera.GiveCafe(20);

            Assert.AreEqual(80, cafetera.GetCantidadDeCafe());
        }
    }
}

