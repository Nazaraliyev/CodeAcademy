using SixteenClothing.Models;
using System.Collections.Generic;

namespace SixteenClothing.ViewModel
{
    public class VmHome : VmSettings
    {
        public List<HomeBanners> banners { get; set; }

        public List<Product> products { get; set; }

        public List<string> Basket { get; set; }
    }
}
