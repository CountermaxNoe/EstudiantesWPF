using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColumnAttribute = SQLite.ColumnAttribute;
using TableAttribute = SQLite.TableAttribute;

namespace EstudiantesWPF.Models
{
    [Table("estudiantes")]
    public class Alumnos
    {
        [PrimaryKey, AutoIncrement]
        public int Id {  get; set; }
        [Column("NumControl"),NotNull]//especificar la columna cuando el nombre es diferente
        public string NumeroControl { get; set; } = null!;
        [NotNull]
        public string Nombre {  get; set; } = null!;
    }
}
