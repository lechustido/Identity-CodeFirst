using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Identity_con_CodeFirst.Models
{
	public class Usuario
	{
		public Guid Id { get; set; }
		public string Nombre { get; set; }
		public Guid AlumnoId { get; set; }
		public Alumno Alumno { get; set; }
	}
}