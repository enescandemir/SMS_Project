using System.ComponentModel.DataAnnotations;

namespace _221229064_BilalEnes_Candemir_Proje.Entitites
{
	public class Account
	{
		[Key]
		public int ID { get; set; }

		public string ?Email { get; set; }

		public string ?Password { get; set; }

		public bool isActive { get; set; }
	}
}
