using ExamManagement.EfLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement.Business
{
    public class DataManagement
    {

        public void manage()
        {
            ExamManagementDbContext cont = new ExamManagementDbContext();
            cont.Person.ToList();
        }
    }
}
