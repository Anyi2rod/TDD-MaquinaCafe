using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MaquinaCafe.models;
using MaquinaCafe.services;

namespace MaquinaCafe.Tests
{
    [TestFixture]
    public class TestMaquinaDeCafe
    {
            [Test]
            public void DeberiaObtenerVasoPequeno()
            {
                var maquina = new MaquinaDeCafe(
                    new Cafetera(100),
                    new Vaso(10, 3),
                    new Vaso(10, 5),
                    new Vaso(10, 7),
                    new Azucarero(20));

                Vaso vaso = maquina.GetTipoVaso("pequeno");

                Assert.AreEqual(3, vaso.GetContenido());
            }

            [Test]
            public void DeberiaEntregarVasoDeCafe()
            {
                var maquina = new MaquinaDeCafe(
                    new Cafetera(100),
                    new Vaso(10, 3),
                    new Vaso(10, 5),
                    new Vaso(10, 7),
                    new Azucarero(20));

                string resultado =
                    maquina.GetVasoDeCafe("pequeno", 1, 2);

                Assert.AreEqual(
                    "Vaso de café servido",
                    resultado);
            }

            [Test]
            public void DeberiaMostrarMensajeSiNoHayVasos()
            {
                var maquina = new MaquinaDeCafe(
                    new Cafetera(100),
                    new Vaso(0, 3),
                    new Vaso(10, 5),
                    new Vaso(10, 7),
                    new Azucarero(20));

                string resultado =
                    maquina.GetVasoDeCafe("pequeno", 1, 2);

                Assert.AreEqual(
                    "No hay vasos disponibles",
                    resultado);
            }

            [Test]
            public void DeberiaMostrarMensajeSiNoHayCafe()
            {
                var maquina = new MaquinaDeCafe(
                    new Cafetera(0),
                    new Vaso(10, 3),
                    new Vaso(10, 5),
                    new Vaso(10, 7),
                    new Azucarero(20));

                string resultado =
                    maquina.GetVasoDeCafe("pequeno", 1, 2);

                Assert.AreEqual(
                    "No hay café suficiente",
                    resultado);
            }

            [Test]
            public void DeberiaMostrarMensajeSiNoHayAzucar()
            {
                var maquina = new MaquinaDeCafe(
                    new Cafetera(100),
                    new Vaso(10, 3),
                    new Vaso(10, 5),
                    new Vaso(10, 7),
                    new Azucarero(0));

                string resultado =
                    maquina.GetVasoDeCafe("pequeno", 1, 2);

                Assert.AreEqual(
                    "No hay azúcar suficiente",
                    resultado);
            }
        
    }
}
