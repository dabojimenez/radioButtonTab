using System;
using System.Collections.Generic;
using System.Text;

namespace RadioButtonTest.Modelos
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public List<Plato> Platos { get; set; }
    }
}
