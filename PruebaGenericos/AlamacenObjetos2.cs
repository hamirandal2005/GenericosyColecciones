using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericos
{
    internal class AlamacenObjetos2<T>
    {
        private T[] datosElemento;
        private int i = 0;

        public AlamacenObjetos2(int j)
        {
            datosElemento = new T[j];

        }

        public void Agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public object GetElemento(int i)
        {
            return datosElemento[i];
        }
    }
}
