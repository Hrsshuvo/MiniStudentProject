using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Core.Model
{
    public class CourseModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
    }
}
