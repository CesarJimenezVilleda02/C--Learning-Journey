using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9
{
    // En las clases sink se ejecutan las callbaks
    internal class CRefri
    {
        // Guardamos sink con los que se comunica el Refri
        private ArrayList sinks = new ArrayList();// los sinks son los listeners

        private int kAlimentos = 0;
        private int grados = 0;

        public CRefri(int kAlimentos, int grados)
        {
            this.kAlimentos = kAlimentos;
            this.grados = grados;
        }

        public void AgregarSink(IEventoRefri pSink)
        {
            if (pSink != null) sinks.Add(pSink);
        }

        public void EliminarSink(IEventoRefri pSink)
        {
            // Contains retorna bool y Remove recibe el objeto en cuestion
            if(sinks.Contains(pSink)) sinks.Remove(pSink);
        }

        public int Kilos { get { return kAlimentos; } }
        public int Grados { get { return grados; } }

        public void Trabajar(int pConsumo)
        {
            kAlimentos -= pConsumo;
            grados++;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{kAlimentos} kilos. {grados} grados.");

            // Verificar para invocar handlers
            if(kAlimentos < 10)
            {
                // Clases que implementen los eventos
                foreach (IEventoRefri sink in sinks)
                {
                    sink.EReservasBajas(kAlimentos);
                }
            }
            if(grados > 0)
            {
                foreach (IEventoRefri sink in sinks)
                {
                    sink.EDescongelado(grados);
                }
            }
        }
    }
}
