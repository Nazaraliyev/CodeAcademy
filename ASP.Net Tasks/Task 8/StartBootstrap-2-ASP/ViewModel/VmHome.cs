using StartBootstrap_2_ASP.Models;
using System.Collections.Generic;

namespace StartBootstrap_2_ASP.ViewModel
{
    public class VmHome
    {
        public Settings settings { get; set; }    
        public List<Product> product { get; set; }   
        public int CartCount { get; set; }
    }
}
