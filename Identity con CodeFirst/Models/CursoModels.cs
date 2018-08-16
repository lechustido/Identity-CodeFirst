using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Identity_con_CodeFirst.Models
{
	public class Curso
	{
	public Guid Id { get; set; }
	public string Nombre { get; set; }
	public virtual ICollection<Alumno> Alumnos{ get; set; }
	}
}