using System.Collections.Generic;
using System.Windows;
using Tipos_de_Inventarios.Entidades;

namespace Tipos_de_Inventarios
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Creando La Primera Lista
            List<Inventarios> inventario1 = new();

            //Agregamos los Resultados del Sistema De Inventario Periodico.
            inventario1.Add(new Inventarios("03/5/2022", 5000, "Compras", 0, 530000, 0));
            inventario1.Add(new Inventarios("Entrada/Diario#1", 0, "@", 0, 0, 0));
            inventario1.Add(new Inventarios("03/5/2022", 1003, "Efectivo Banco", 0, 0, 530000));
            inventario1.Add(new Inventarios("Entrada/Diario#1", 0, "@", 0, 0, 0));
            inventario1.Add(new Inventarios("09/12/2022", 02, "Banco Dominicano", (530000), 0, 0));
            inventario1.Add(new Inventarios("Entrada/Diario#1", 0, "Reg.Compras De Mercancia", 0, 0, 0));

            inventario1.Add(new Inventarios("25/5/2022", 1000, "Efectivo Caja", 0, 195000, 0));
            inventario1.Add(new Inventarios("Entrada/Diario#2", 0, "@", 0, 0, 0));
            inventario1.Add(new Inventarios("03/12/2022", 4000, "Ventas", 0, 0, 19500));
            inventario1.Add(new Inventarios("Entrada/Diario#2", 0, "Reg.Venta De Mercancia", 0, 0, 0));

            DetalleDataGrid1.ItemsSource = inventario1;

            //Creando La Segunda Lista
            List<Inventarios> inventario2 = new();

            //Agregamos los Resultados del Sistema De Inventario Perpetuo.
            inventario2.Add(new Inventarios("05/5/2022", 1010, "Inventario", 0, 530000, 0));
            inventario2.Add(new Inventarios("Entrada/Diario#1", 0, "@", 0, 0, 0));
            inventario2.Add(new Inventarios("05/5/2022", 1003, "Efectivo Banco", 0, 0, 530000));
            inventario2.Add(new Inventarios("Entrada/Diario#1", 0, "@", 0, 0, 0));
            inventario2.Add(new Inventarios("09/12/2022", 02, "Banco Dominicano", (530000), 0, 0));
            inventario2.Add(new Inventarios("Entrada/Diario#1", 0, "Reg.Compras De Mercancia", 0, 0, 0));

            inventario2.Add(new Inventarios("25/5/2022", 1000, "Efectivo Caja", 0, 195000, 0));
            inventario2.Add(new Inventarios("Entrada/Diario#2", 0, "@", 0, 0, 0));
            inventario2.Add(new Inventarios("03/12/2022", 4000, "Ventas", 0, 0, 19500));
            inventario2.Add(new Inventarios("Entrada/Diario#2", 0, "Reg.Venta De Mercancia", 0, 0, 0));

            DetalleDataGrid2.ItemsSource = inventario2;
        }     
    }
}
