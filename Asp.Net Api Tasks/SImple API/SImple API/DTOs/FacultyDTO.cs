using Simple_API.Model;
using System.Collections.Generic;

namespace Simple_API.DTOs
{
    public class FacultyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SmallName { get; set; }
        public List<FacultyQualificationDTO> qualification { get; set; }
    }
}
