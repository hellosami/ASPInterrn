using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AppliedJobDTO
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int Sid { get; set; }
        public string Date { get; set; }
        public string JobStatus { get; set; }
    }
}
