using StartBootstrap_Asp.Models;
using System.Collections.Generic;

namespace StartBootstrap_Asp.ViewModel
{
	public class VmHome
	{
		public Settings settings { get; set; }
		public List<SosialMedia> sosialMedia { get; set; }
		public List<Portfolio> portfolios { get; set; }
		public ContactMessage contactMessage { get; set; }
	}
}
