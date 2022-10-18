using RadioButtonTest.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RadioButtonTest.Datos
{
    public class CategoriaDataBase
    {
        public static ObservableCollection<Categoria> SelectCategoria()
        {
            return new ObservableCollection<Categoria>
            {
                new Categoria(){ IdCategoria = 1, Descripcion = "Desayuno", Cantidad = SelectPlatos().Where(p => p.IdCategoria == 1).ToList().Count},
                new Categoria(){ IdCategoria = 2, Descripcion = "Almuerzo", Cantidad = SelectPlatos().Where(p => p.IdCategoria == 2).ToList().Count},
                new Categoria(){ IdCategoria = 3, Descripcion = "Cena", Cantidad = SelectPlatos().Where(p => p.IdCategoria == 3).ToList().Count},
                new Categoria(){ IdCategoria = 4, Descripcion = "Plato Fuerte", Cantidad = SelectPlatos().Where(p => p.IdCategoria == 4).ToList().Count},
                new Categoria(){ IdCategoria = 5, Descripcion = "Bebidas", Cantidad = SelectPlatos().Where(p => p.IdCategoria == 5).ToList().Count},
                new Categoria(){ IdCategoria = 6, Descripcion = "Postres", Cantidad = SelectPlatos().Where(p => p.IdCategoria == 6).ToList().Count},
                new Categoria(){ IdCategoria = 7, Descripcion = "Aperritivos", Cantidad = SelectPlatos().Where(p => p.IdCategoria == 7).ToList().Count},
            };
        }
        public static ObservableCollection<Plato> SelectPlatos()
        {
            return new ObservableCollection<Plato>
            {
                new Plato(){ IdCategoria = 1, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 2, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 3, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 1, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 3, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 4, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 1, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 4, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 2, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 1, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 5, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 1, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 6, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 7, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 1, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 5, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 1, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 6, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 1, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 7, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 4, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 1, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 4, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 2, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 7, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 7, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 7, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 6, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 7, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 6, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 5, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 3, Descripcion = "Huevos"},
                new Plato(){ IdCategoria = 6, Descripcion = "Huevos"}
            };
        }
    }
}
