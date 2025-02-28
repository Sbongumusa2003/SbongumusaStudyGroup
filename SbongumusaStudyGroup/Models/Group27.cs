using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SbongumusaStudyGroup.Models
{
	public class Group27
	{
		[DisplayName("STUDENT NUMBER")]
		public string StudentNumber { get; set; }
		[DisplayName("NAME")]
		public string Name { get; set; }
		[DisplayName("SURNAME")]
		public string Surname { get; set; }
		[DisplayName("EMAIL ADDRESS")]
		public string Email { get; set; }
	}
}