using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Question> Questions { get; set; }
        public List<PersonsExam> PersonsExam { get; set; }


    }
}
