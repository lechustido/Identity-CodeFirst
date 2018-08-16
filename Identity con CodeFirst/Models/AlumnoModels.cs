using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Identity_con_CodeFirst.Models
{
	public class Alumno
	{
		public Guid Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int Edad { get; set; }
		public virtual ICollection<Matricula> Matriculas { get; set; }
		public virtual ICollection<Curso> Cursos { get; set; }
		
	}
}
 