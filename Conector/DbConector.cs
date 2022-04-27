using MpfProyect.Models;
using System;

namespace MpfProyect.Conector
{
    public class DbConector
    {
        public Personacollection ListarPersona()
        {

            Personacollection personas = new Personacollection
            {
                new Persona(1, "Juan Carlos", DateTime.Now),
                new Persona(2, "Miguel", DateTime.Now),
                new Persona(3, "Julia", DateTime.Now),
                new Persona(4, "Sofia", DateTime.Now),
                new Persona(5, "Iñigo", DateTime.Now)
            };

            return personas;
        }

        public void ListarPersona(Personacollection personas)
        {

            personas.Add(new Persona(1, "Juan Carlos", DateTime.Now));
            personas.Add(new Persona(2, "Miguel", DateTime.Now));
            personas.Add(new Persona(3, "Julia", DateTime.Now));
            personas.Add(new Persona(4, "Sofia", DateTime.Now));
            personas.Add(new Persona(5, "Iñigo", DateTime.Now));
        }
    }
}
