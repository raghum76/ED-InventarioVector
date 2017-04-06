using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_16.Inventario
{
    class Inventario
    {
        private Producto[] _productos;
        private int _cantidad;

        public Inventario()
        {
            _productos = new Producto[15];
            _cantidad = 0;
        }

        public void agregar(Producto producto)
        {
            if (_cantidad < 15)
            {
                _productos[_cantidad] = producto;
                _cantidad++;
            }
        }

        public Producto buscar(string codigo)
        {
            for(short i = 0; i < _cantidad; i++)
            {
                if (codigo == _productos[i].codigo)
                    return _productos[i];
            }
            return null;
        }

        public void borrar(string codigo)
        {
            //for (short i = 0; i < _cantidad; i++)
            //{
            //    if (codigo == _productos[i].codigo)
            //    {
            //        _productos[i] = null;
            //        _cantidad--; 
            //        reacomodar(i);
            //        break;
            //    }
            //}

            short i = 0;
            bool encontrado = false;
            while (i < _cantidad && !encontrado)
            {
                if (codigo == _productos[i].codigo)
                {
                    _productos[i] = null;
                    _cantidad--;
                    reacomodar(i);
                    encontrado = true;
                }
                i++;
            }

        }

        public string reporte()
        {
            string cadena = "";
            for (short i = 0; i < _cantidad; i++)
            {
                cadena += _productos[i].ToString() + Environment.NewLine;
            }
            return cadena;
        }

        public void insertar(Producto producto, int posicion)
        {
            if (_cantidad < 15 && posicion >= 0 && posicion <= _cantidad)
            {
                for (int i = _cantidad; i > posicion; i--)
                {
                    _productos[i] = _productos[i - 1];
                }
                _productos[posicion] = producto;
                _cantidad++;
            }
        }

        public void reacomodar(int posicion)
        {
            for(int i = posicion; i < _cantidad; i++) 
            {
                _productos[i] = _productos[i + 1];
            }
            _productos[_cantidad] = null;
        }
    }
}
