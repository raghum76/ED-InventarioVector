using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_16.Inventario
{
    class Producto
    {
        private string _codigo;
        public string codigo
        {
            get { return _codigo; }
        }

        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
        }

        private int _cantidad;
        public int cantidad
        {
            get { return _cantidad; }
        }

        private float _precio;
        public float precio
        {
            get { return _precio; }
        }

        public Producto(string codigo, string nombre, int cantidad, float precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _precio = precio;
        }

        public override string ToString()
        {
            return _codigo + Environment.NewLine + _nombre + Environment.NewLine + _cantidad + Environment.NewLine + _precio + Environment.NewLine;
        }
    }
}
