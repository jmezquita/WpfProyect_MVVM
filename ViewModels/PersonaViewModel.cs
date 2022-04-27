using MpfProyect.Conector;
using MpfProyect.Core.Commands;
using MpfProyect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MpfProyect.ViewModels
{
    public class PersonaViewModel:IGeneric
    {


        private Personacollection _listaPersonas = new Personacollection();


        /// <summary>
        /// Lista de persona
        /// </summary>
        public Personacollection ListaPersonas { 
            get => _listaPersonas; 
            set
            {
                _listaPersonas = value;
                RaisePropertyChanged("ListaPersonas");
            } 
        } 
   

        private Persona _CurrentPersona;
        /// <summary>
        /// Persona actual
        /// </summary>
        public Persona CurrentPersona
        {
            get => _CurrentPersona;
            set
            {
                _CurrentPersona = value;
                RaisePropertyChanged("CurrentPersona");
            }
        }

        private ICommand _ListarPersonaCommand;

        public ICommand ListarPersonaCommand {
            get
            {
                if (_ListarPersonaCommand == null)
                    _ListarPersonaCommand = new RelayCommand(new Action(ListarPersona));

                       return _ListarPersonaCommand;
                }        
            }


        private ICommand _limpiarPersonas;

        public ICommand LimpiarPersonaCommand
        {
            get
            {
                if (_limpiarPersonas==null)
                    _limpiarPersonas = new RelayCommand(new Action(LimpiarPersona));

                return _limpiarPersonas;

            }
        }

        private void LimpiarPersona()
        {
            ListaPersonas.Clear();
        }

        private void ListarPersona()
        {
            ListaPersonas =App.DbConector.ListarPersona();


            //if (CurrentPersona != null)
            //    MessageBox.Show($"La persona Actual es {CurrentPersona.Nombre}");
            //else
            //    MessageBox.Show("No existen persona seleccionadas");
        }
        public PersonaViewModel()
        {
            //_listaPersonas.Add(new Persona() { 1,"Juan Carlos", })
        }

    }
}
