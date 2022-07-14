using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial10
{
    // Definicion de delegados
    public delegate void DReservasBajas(int pkilos);
    public delegate void DDescongelado(int pGrados);

    internal class CRefri
    {
        private int kAlimentos = 0;
        private int grados = 0;

        // Variables que guardan funciones -- un delegado es el tipo de funcion
        private DDescongelado delDescongelado;
        private DReservasBajas delReservasBajas;

        public CRefri(int kAlimentos, int grados)
        {
            this.kAlimentos = kAlimentos;
            this.grados = grados;
        }

        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            //delReservasBajas = pMetodo;

            // Los delegados tienen la sobrecarga que agrega delegados a una ArrayList, pudiendo tener varios delegados
            delReservasBajas += pMetodo;
        }
        public void EliminaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservasBajas -= pMetodo;
        }

        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado += pMetodo;
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
            if (kAlimentos < 10)
            {
                // Automaticamente recorre su lista interna de funciones y los invoca
                delReservasBajas(kAlimentos);
            }
            if (grados > 0)
            {
                delDescongelado(grados);
            }
        }
    }
}
