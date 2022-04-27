using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpfProyect.Models
{

    public class Personacollection :ObservableCollection<Persona>
    {

    }


    public  class Persona
    {
 
        /// <summary>
        /// id de la persona
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Fecha de nacimiento de la persona
        /// </summary>
        public DateTime FechaNac { get; set; }

        public Persona()
        {

        }

        public Persona(int id, string nombre, DateTime fechanac)
        {
            Id = id;
            Nombre = nombre; ;
            FechaNac = fechanac;    
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
