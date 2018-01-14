using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement.Models
{
    public class PersonsExam
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public Exam Exam { get; set; }
        public PersonExamStatus Status { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
