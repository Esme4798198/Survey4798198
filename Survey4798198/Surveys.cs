using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey4798198
{
    /// <summary>
    /// Declaración de la clase Surveys
    ///  Propiedad pública de tipo string para almacenar el nombre
    ///  Propiedad pública de tipo DateTime para almacenar la fecha de nacimiento
    ///  Propiedad pública de tipo string para almacenar el equipo favorito
    ///  Sobrescribe el método ToString para proporcionar una representación en forma de cadena del objeto Surveys
    ///  Devuelve una cadena formateada con el nombre, fecha de nacimiento y equipo favorito
    /// </summary>
    public class Surveys
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string FavoriteTeam { get; set; }

        public override string ToString()
        {
            return $"{Name} | {Birthdate} | { FavoriteTeam}";
        }
    }
}
