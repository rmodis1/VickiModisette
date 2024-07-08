using System;
using System.ComponentModel.DataAnnotations;

namespace VickiModisette.Models
{
	public class ContactModel
	{
		public int ClientId { get; set; }
		[Required]
		public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; } = string.Empty;
		public DateTime TimeSubmitted { get; set; }
	}
}

