using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Magic_8_Ball_HW
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        static void Main()
        {
           App app = new App();
           MainWindow window = new MainWindow();
           IModel model = new Model();
           Presenter presenter = new Presenter(window);
           app.Run(window);
        }
    }
}