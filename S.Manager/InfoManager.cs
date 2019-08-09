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
    public class InfoManager
    {
        readonly InfoRepository _infoRepository = new InfoRepository();

        public bool Save(StudentInfoModel category)
        {
            var save = _infoRepository.Save(category);
            return save;
        }

        public bool IsNameExist(string name)
        {
            var isExist = false;
            var category = _infoRepository.DepartmentId(name);
            if (category != null)
                isExist = true;
            return isExist;
        }
        public SqlDataReader GetCourseId(string roll)
        {
            var reader = _infoRepository.GetCourseId(roll);
            return reader;
        }
        public SqlDataReader GetDepartmentId(string roll)
        {
            var reader = _infoRepository.GetDepartmentId(roll);
            return reader;
        }
        public SqlDataReader GetStudentId()
        {
            var reader = _infoRepository.GetStudentId();
            return reader;
        }
        public SqlDataReader GetStudentName(string roll)
        {
            var reader = _infoRepository.GetStudentName(roll);
            return reader;
        }
    }
}
