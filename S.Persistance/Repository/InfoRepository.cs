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
    public class InfoRepository
    {
        private readonly string _connectionString = SDB.ConnectionString();
        readonly SDB _sDB = new SDB();

        public bool Save(StudentInfoModel category)
        {
            try
            {
                var query = "INSERT INTO tblStudentInfo (StudentId, DepartmentId, CourseId) VALUES('" + category.StudentId + "','" + category.DepartmentId + "','" + category.CourseId + "')";
                var rowAffected = _sDB.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public StudentInfoModel DepartmentId(string DepartmentId)
        {
            try
            {
                var query = "SELECT * FROM tblStudentInfo WHERE DepartmentId='" + DepartmentId + "'";
                var reader = _sDB.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var StudentInfoModel = new StudentInfoModel()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        StudentId = Convert.ToInt32(reader["StudentId"]),
                        DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                      
                    };
                    return StudentInfoModel;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataReader GetStudentId()
        {
            try
            {
                var query = "select * from tblStudent";
                var reader = _sDB.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataReader GetStudentName(string roll)
        {
            try
            {
                var query = "select tblStudent.StudentName  from tblStudent where tblStudent.Roll = '"+roll+"'";
                var reader = _sDB.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public SqlDataReader GetDepartmentId(string roll)
        {
            try
            {
                var query = "select tblDepartment.Department from tblStudent join tblDepartment on tblDepartment.Id = tblStudent.DepartmentId where tblStudent.Roll = '"+roll+"'";
                var reader = _sDB.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataReader GetCourseId(string roll)
        {
            try
            {
                var query = "select tblCourse.CourseName  from tblStudent join tblCourse on tblCourse.Id = tblStudent.CourseId where tblStudent.Roll = '" + roll + "'";
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
