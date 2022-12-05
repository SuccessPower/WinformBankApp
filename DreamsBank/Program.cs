using DreamsBank.Implementation;
using DreamsBank.Interface;
using DreamsBank.UI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamsBank
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartingPage());
            //Application.Run(new signUpPage());
        }

        private static void ConfigurationServices(ServiceCollection services)
        {
            services.AddScoped<IAccount, AccountImplementation>();
            services.AddSingleton<ITransaction, TransactionImplementation>();
            services.AddSingleton<IUser, UserImplementation>();

        }
    }
}
