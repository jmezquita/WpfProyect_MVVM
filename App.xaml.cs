using MpfProyect.Conector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MpfProyect
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static DbConector _dbConector = new DbConector();
        public static DbConector DbConector => _dbConector;
    }
}
