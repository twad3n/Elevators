using Elevators.Presenters;
using Elevators.Views;
using Elevators.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevators
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Ninject.StandardKernel kernel = new StandardKernel();
            //kernel.Bind<SettingsView>().To<ISettingsPresenter>();
            

            Form mainMenu = new MainView();
            Form settingsMenu = new SettingsView();
            Form scenarioMenu = new ScenarioView();

            //MainPresenter mainPresenter = new MainPresenter(mainMenu);

            //mainMenu.Show();
           
            Application.Run(mainMenu);
        }
    }

    
}
