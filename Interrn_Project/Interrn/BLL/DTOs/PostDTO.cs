using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PostDTO
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Titel { get; set; }
        public string JobDescription { get; set; }
        public string Location { get; set; }
        public string Program { get; set; }
        public string Skills { get; set; }
        public string DeadLine { get; set; }
    }
}
