using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string Program { get; set; }
        public string Skills { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
    }
}
