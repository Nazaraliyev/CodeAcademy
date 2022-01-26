﻿using System.ComponentModel.DataAnnotations;

namespace Biziness.View_Model
{
	public class VmUserLogin
	{
		[MaxLength(100), Required, EmailAddress]
		public string Login { get; set; }



		[Required]
		public string Password { get; set; }
	}
}
