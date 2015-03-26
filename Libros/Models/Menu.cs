using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros.Models
{
    public class Menu
    {
        private ObservableCollection<ItemMenu> data;

        public ObservableCollection<ItemMenu> Data{
        get
        {
            if (data == null)
            {
                data = new ObservableCollection<ItemMenu>();
                ItemMenu item1 = new ItemMenu()
                {
                    Titulo = "Cien Años de Soledad",
                    Descripcion = "Gabriel Garcia Marquez"
                };
                ItemMenu item2 = new ItemMenu()
                {
                    Titulo = "El Principito",
                    Descripcion = "Antoine de Saint-Exupery"
                    
                };
                ItemMenu item3 = new ItemMenu()
                {
                    Titulo = "Crimen y Castigo",
                    Descripcion = "Fiodor Dostoievski"

                };
                ItemMenu item4 = new ItemMenu()
                {
                    Titulo = "Orgullo y Prejuicio ",
                    Descripcion = "Jane Austen"

                };
                data.Add(item1);
                data.Add(item2);
                data.Add(item3);
                data.Add(item4);


            }
            return data;
        }
            set { data = value; }
        }

    }
}
