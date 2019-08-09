using S.Core.Model;
using S.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Manager
{
    public class CourseManager
    {
        readonly CourseRepository _courseRepository = new CourseRepository();

        public bool Save(CourseModel category)
        {
            var save = _courseRepository.Save(category);
            return save;
        }

        public bool IsNameExist(string name)
        {
            var isExist = false;
            var category = _courseRepository.GetByCourse(name);
            if (category != null)
                isExist = true;
            return isExist;
        }
        public SqlDataReader GetDepartmentId()
        {
            var reader = _courseRepository.GetDepartmentId();
            return reader;
        }
    }

}
