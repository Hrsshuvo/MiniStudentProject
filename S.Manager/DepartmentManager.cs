using S.Core.Model;
using S.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Persistance
{
    public class DepartmentManager
    {
        readonly DepartmentRepository _departmentRepository = new DepartmentRepository();

        public bool Save(DepartmentModel category)
        {
            var save = _departmentRepository.Save(category);
            return save;
        }

        public bool IsNameExist(string name)
        {
            var isExist = false;
            var category = _departmentRepository.GetByDepartment(name);
            if (category != null)
                isExist = true;
            return isExist;
        }
        public SqlDataReader GenarateAutoId()
        {
            var reader = _departmentRepository.GenarateAutoId();
            return reader;
        }
    }
}
