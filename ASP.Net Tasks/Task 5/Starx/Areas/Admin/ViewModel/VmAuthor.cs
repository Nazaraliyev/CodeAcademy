using Starx.Models;
using System.Collections.Generic;

namespace Starx.Areas.Admin.ViewModel
{
    public class VmAuthor
    {
        public List<Author> authors { get; set; }
        public Author author { get; set; }

        public Author update { get; set; }
    }
}
