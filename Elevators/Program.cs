using Elevators.Presenters;
using Elevators.Views;
using Elevators.Models;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elevators.Models.Services;
using Elevators.Models.Repositories;

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

            //Form mainMenu = new MainView();
            //Form settingsMenu = new SettingsView();
            //Form scenarioMenu = new ScenarioView();

            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<IMainView>().To<MainView>();
            kernel.Bind<MainPresenter>().ToSelf();
            kernel.Bind<ISettingsView>().To<SettingsView>();
            kernel.Bind<SettingsPresenter>().ToSelf();
            kernel.Bind<IScenarioView>().To<ScenarioView>();
            kernel.Bind<ScenarioPresenter>().ToSelf();
            kernel.Bind<IOperatorService>().To<OperatorService>();
            kernel.Bind<ISettingsService>().To<SettingsService>();
            //kernel.Bind<IRepository<SettingsRepository>>().To<CharacterRepository>();
            //kernel.Bind<OperatorPresenter>().ToSelf();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            kernel.Get<MainPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());



            //mainMenu.Show();

            //Application.Run(mainMenu);
        }
    }

    
}
