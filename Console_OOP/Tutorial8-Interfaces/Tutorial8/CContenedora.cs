using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial8
{
    class CContenedora : IEnumerable
    {
        private int[] valores = new int[10];

        public CContenedora()
        {
            for(int i = 0; i < 10; i++) valores[i] = i * i;
        }

        // Implementacion del GetEnumerator necesario por IEnumerable
        //IEnumerator IEnumerable.GetEnumerator() -- tambien correcto
        // retorno enumerador y especificamos la Interfaz.MetodoQueNecesita
        public IEnumerator GetEnumerator()
        {
            return new ContenedorEnum(valores);
        }
    }

    class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        //Se le pone -1 para que empiece desde el 0 con el primer MoveNext()
        private int posicion = -1;

        public ContenedorEnum(int[] arreglo)
        {
            this.arreglo = arreglo;
        }

        public bool MoveNext()
        {
            posicion++;
            if(posicion < arreglo.Length)
            {
                return true;
            } else
                return false;
        }

        // Current es una propiedad
        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }

        public void Reset() => posicion = 0;
    }
}
