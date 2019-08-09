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
    public class StudentRepository
    {
        private readonly string _connectionString = SDB.ConnectionString();
        readonly SDB _sDB = new SDB();

        public bool Save(StudentModel category)
        {
            try
            {
                var query = "INSERT INTO tblStudent (DepartmentId, CourseId, StudentName,Roll,Email) VALUES('" + category.DepartmentId + "','" + category.CourseId + "','" + category.StudentName + "','" + category.Roll + "','"+category.Email+"')";
                var rowAffected = _sDB.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public StudentModel Roll(string Roll)
        {
            try
            {
                var query = "SELECT * FROM tblStudent WHERE Roll='" + Roll + "'";
                var reader = _sDB.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var StudentModel = new StudentModel()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                        StudentName = reader["StudentName"].ToString(),
                        Roll = reader["Roll"].ToString(),
                        Email = reader["Email"].ToString()
                        
                    };
                    return StudentModel;
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
        public SqlDataReader GetAllId()
        {
            try
            {
                var query = "SELECT Id,CourseName FROM tblCourse";
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
