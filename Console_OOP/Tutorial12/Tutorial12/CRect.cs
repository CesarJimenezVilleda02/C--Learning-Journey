using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial12
{
    internal class CRect
    {
        public int lado1 { get { return lado1;  } set { area = value * lado2; lado1 = value; } }
        public int lado2 { get { return lado2; } set { area = value * lado1; lado2 = value; } }

        public int area = 0;

        public CRect()
        {
            this.lado1 = 0;
            this.lado2 = 0;
            this.area = 0;
        }public CRect(int lado1, int lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.area = lado1 * lado2;
        }

        // el overloading debe llevar public static operator
        // BINARIOS
        // result = rec1 - rec2
        public static CRect operator +(CRect rec1, CRect rec2)
        {
            CRect temp = new CRect();
            temp.area = rec1.area + rec2.area;
            return temp;
        }
        public static CRect operator -(CRect rec1, CRect rec2)
        {
            CRect temp = new CRect();
            temp.area = rec1.area - rec2.area;
            return temp;
        }
        public static CRect operator *(CRect rec1, CRect rec2)
        {
            CRect temp = new CRect();
            temp.area = rec1.area * rec2.area;
            return temp;
        }
        public static CRect operator /(CRect rec1, CRect rec2)
        {
            CRect temp = new CRect();
            temp.area = rec1.area / rec2.area;
            return temp;
        }

        // UNARIOS
        // Si ya hicimos + y - el += y el -= ya quedan sobrecargados
        public static CRect operator ++(CRect rec)
        {
            rec.area = rec.area + 10;
            return rec;
        }
        public static CRect operator --(CRect rec)
        {
            rec.area = rec.area - 10;
            return rec;
        }
        // para el == debemos cambiar este metodo heredado de obj
        public override bool Equals(object obj)
            // este es desde el objeto viendo el que recibes
        {
            if(obj is CRect)
            {
                CRect rect = (CRect)obj;
                if(this.area == rect.area) return true;
                return false;
            }
            return false;
        }
        //Cuando sobrecargas == debes sobrecargar != forzosamente
        public static bool operator ==(CRect rec1, CRect rec2)
        {
            return rec1.Equals(rec2);
        }
        public static bool operator !=(CRect rec1, CRect rec2)
        {
            return !(rec1.Equals(rec2));
        }

        // Sobrecarga de operadores de comparacion
        public int CompareTo(object obj)
        {
            CRect temp = (CRect)obj;
            if(this.area > temp.area) return 1;
            else if(this.area < temp.area) return -1;
            else return 0;
        }
        public static bool operator <(CRect rec1, CRect rec2)
        {
            // rec1.CompareTo(rec2)
            return rec1.area < rec2.area;
        }
        public static bool operator >(CRect rec1, CRect rec2)
        {
            return rec1.area > rec2.area;
        }

    }
}
