using Biziness.Models;
using System.Collections.Generic;

namespace Biziness.View_Model
{
    public class VmService
    {
        public List<Service> Services { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
    }
}
