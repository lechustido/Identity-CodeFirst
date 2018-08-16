using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Identity_con_CodeFirst.Models
{
	public class Matricula
	{
		public Guid Id { get; set; }
		public Guid AlumnoId { get; set; }
		public string Curso { get; set; }
		public int Precio { get; set; }
		public virtual Alumno Alumno { get; set; }
	}
}