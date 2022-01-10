using Benco.Models;
using System.Collections.Generic;

namespace Benco.ViewModel
{
    public class VmBlogCreate
    {
        public Blog blog { get; set; }
        public List<BlogTag> blogTag { get; set; }
        public List<Category> category { get; set; }
        public List<int> Tags  { get; set; }
    }
}
