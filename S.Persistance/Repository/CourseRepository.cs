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
    public class CourseRepository
    {
        private readonly string _connectionString = SDB.ConnectionString();
        readonly SDB _sDB = new SDB();

        public bool Save(CourseModel category)
        {
            try
            {
                var query = "INSERT INTO tblCourse (DepartmentId, CourseCode, CourseName) VALUES('" + category.DepartmentId + "','" + category.CourseCode + "','" + category.CourseName + "')";
                var rowAffected = _sDB.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public CourseModel GetByCourse(string Course)
        {
            try
            {
                var query = "SELECT * FROM tblCourse WHERE CourseName='" + Course + "'";
                var reader = _sDB.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var CourseModel = new CourseModel()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                        CourseCode = reader["CourseCode"].ToString(),
                        CourseName = reader["CourseName"].ToString()
                    };
                    return CourseModel;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataReader GetDepartmentId()
        {
            try
            {
                var query = "SELECT Id,Department FROM tblDepartment";
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
