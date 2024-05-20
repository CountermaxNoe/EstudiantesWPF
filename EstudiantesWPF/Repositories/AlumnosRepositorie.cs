using EstudiantesWPF.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesWPF.Repositories
{
    public class AlumnosRepositorie
    {
        SQLite.SQLiteConnection conexion;

        public AlumnosRepositorie()
        {
            conexion = new("Alumnos SQLite");
        }

        public IEnumerable<Alumnos> GetAll()
        {
            return conexion.Table<Alumnos>().OrderBy(x=>x.Nombre);
        }
        public void Insert(Alumnos alumno)
        {
            conexion.Insert(alumno);
        }
        public void Update(Alumnos alumno)
        {
            conexion.Update(alumno);
        }
        public void Delete(Alumnos alumno)
        {
            conexion.Delete(alumno);
        }
    }
}
