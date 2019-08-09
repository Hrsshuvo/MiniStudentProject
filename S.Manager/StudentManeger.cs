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
    public class StudentManeger
    {
        readonly StudentRepository _studentRepository = new StudentRepository();

        public bool Save(StudentModel category)
        {
            var save = _studentRepository.Save(category);
            return save;
        }

        public bool IsNameExist(string name)
        {
            var isExist = false;
            var category = _studentRepository.Roll(name);
            if (category != null)
                isExist = true;
            return isExist;
        }
        public SqlDataReader GetAllId()
        {
            var reader = _studentRepository.GetAllId();
            return reader;
        }
    public SqlDataReader GetDepartmentId()
        {
            var reader = _studentRepository.GetDepartmentId();
            return reader;
        }
    }
}
