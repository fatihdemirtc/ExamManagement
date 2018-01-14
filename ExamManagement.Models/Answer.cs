using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public PersonsExam PersonsExam { get; set; }
        public Question Question { get; set; }
        public Option Option { get; set; }

    }
}
