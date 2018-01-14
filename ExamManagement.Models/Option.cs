using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement.Models
{
    public class Option
    {
        public int Id { get; set; }
        public string text { get; set; }
        public Question question { get; set; }
    }
}
