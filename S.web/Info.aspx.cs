using S.Core.Model;
using S.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S.web
{
    public partial class Info : System.Web.UI.Page
    {
        readonly InfoManager _infoManager = new InfoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LodeRoll();
            }

        }

        public void LodeRoll()
        {
            try
            {

                var subject = _infoManager.GetStudentId();
                dropdownRoll.DataSource = subject;
                dropdownRoll.DataTextField = "Roll";
                dropdownRoll.DataValueField = "Id";
                dropdownRoll.DataBind();
                dropdownRoll.SelectedIndex = -1;

            }
            catch (Exception e)
            {
                lblMessege.Text = e.Message;
            }
        }

        protected void dropdownRoll_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblMessege.Text = "";
                if (dropdownRoll.SelectedValue != null)
                {
                    var item = new StudentInfoModel();
                    string StudentId = (dropdownRoll.SelectedItem.ToString());
                    var reader = _infoManager.GetStudentName(StudentId);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtName.Text = reader["StudentName"].ToString();
                        }

                    }

                    StudentInfoModel stock = new StudentInfoModel();
                    string CourseId = (dropdownRoll.SelectedItem.ToString());
                    var reader1 = _infoManager.GetCourseId(CourseId);
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            var courseNames = reader1["CourseName"].ToString();
                            if (String.IsNullOrEmpty(courseNames))
                            {
                                txtCourse.Text = 0.ToString();
                                return;
                            }

                            txtCourse.Text = courseNames;
                        }
                    }

                    
                    string DepartmentId = (dropdownRoll.SelectedItem.ToString());
                    var reader12 = _infoManager.GetDepartmentId(DepartmentId);
                    if (reader12.HasRows)
                    {
                        while (reader12.Read())
                        {
                            var departnents = reader12["Department"].ToString();
                            if (String.IsNullOrEmpty(departnents))
                            {
                                txtdepartment.Text = 0.ToString();
                                return;
                            }

                            txtdepartment.Text = departnents;
                        }
                    }

                    return;
                }
                txtName.Text = 0.ToString();
            }
            catch (Exception exception)
            {
                lblMessege.Text = exception.Message;
            }
        }
    }
}