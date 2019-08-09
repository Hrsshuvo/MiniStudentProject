using S.Core.Model;
using S.Persistance.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Persistance.Repository
{
    public class DepartmentRepository
    {
        private readonly string _connectionString = SDB.ConnectionString();
        readonly SDB _sDB = new SDB();

        public bool Save(DepartmentModel category)
        {
            try
            {
                var query = "INSERT INTO tblDepartment (Code, Department) VALUES('" + category.Code + "','" + category.Department + "')";
                var rowAffected = _sDB.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DepartmentModel GetByDepartment(string Department)
        {
            try
            {
                var query = "SELECT * FROM tblDepartment WHERE Department='" + Department + "'";
                var reader = _sDB.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var category = new DepartmentModel()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Code = reader["Code"].ToString(),
                        Department = reader["Department"].ToString()
                    };
                    return category;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataReader GenarateAutoId()
        {
            try
            {
                var query = "Select ISNULL ( MAX ( cast Id As int )),0) + 1 from tblDepartment)";

                var reader = _sDB.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
