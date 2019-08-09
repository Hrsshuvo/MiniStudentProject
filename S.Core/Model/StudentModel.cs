using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Core.Model
{
    public class StudentModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public string StudentName { get; set; }
        public string Roll { get; set; }
        public String Email { get; set; }
    }
}
