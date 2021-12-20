using SixteenClothing.Models;
using System.Collections.Generic;

namespace SixteenClothing.ViewModel
{
    public class VmAboutUs:VmSettings
    {
        public List<TeamMembers> teams { get; set; }

        public List<Quality> qualities { get; set; }

        public List<Partners> partners { get; set; }
    }
}
