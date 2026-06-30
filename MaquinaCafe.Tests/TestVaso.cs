using MaquinaCafe.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Tests
{
    [TestFixture]
    public class TestVaso
    {
        [Test]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(2, 10);

            bool resultado = vasosPequenos.HasVasos(1);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(1, 10);

            bool resultado = vasosPequenos.HasVasos(2);

            Assert.IsFalse(resultado);
        }

        [Test]
        public void DeberiaRestarCantidadDeVasos()
        {
            Vaso vasosPequenos = new Vaso(5, 10);

            vasosPequenos.GiveVasos(1);

            Assert.AreEqual(4, vasosPequenos.GetCantidadVasos());
        }
    }
}
