using MaquinaCafe.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.services
{
    public class MaquinaDeCafe
    {
    
            private Cafetera cafetera;
            private Vaso vasosPequenos;
            private Vaso vasosMedianos;
            private Vaso vasosGrandes;
            private Azucarero azucarero;

            public MaquinaDeCafe(
                Cafetera cafetera,
                Vaso vasosPequenos,
                Vaso vasosMedianos,
                Vaso vasosGrandes,
                Azucarero azucarero)
            {
                this.cafetera = cafetera;
                this.vasosPequenos = vasosPequenos;
                this.vasosMedianos = vasosMedianos;
                this.vasosGrandes = vasosGrandes;
                this.azucarero = azucarero;
            }

            public Vaso GetTipoVaso(string tipoDeVaso)
            {
                switch (tipoDeVaso.ToLower())
                {
                    case "pequeno":
                        return vasosPequenos;

                    case "mediano":
                        return vasosMedianos;

                    case "grande":
                        return vasosGrandes;

                    default:
                        return null;
                }
            }

            public string GetVasoDeCafe(
                string tipoDeVaso,
                int cantidadDeVasos,
                int cantidadDeAzucar)
            {
                Vaso vaso = GetTipoVaso(tipoDeVaso);

                if (vaso == null)
                    return "Tipo de vaso inválido";

                if (!vaso.HasVasos(cantidadDeVasos))
                    return "No hay vasos disponibles";

                if (!cafetera.HasCafe(vaso.GetContenido()))
                    return "No hay café suficiente";

                if (!azucarero.HasAzucar(cantidadDeAzucar))
                    return "No hay azúcar suficiente";

                vaso.GiveVasos(cantidadDeVasos);
                cafetera.GiveCafe(vaso.GetContenido());
                azucarero.GiveAzucar(cantidadDeAzucar);

                return "Vaso de café servido";
            }
        }
    }


