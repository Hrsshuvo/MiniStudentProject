using S.Core.Model;
using S.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S.web
{
    public partial class Course : System.Web.UI.Page
    {
        readonly CourseManager _courseManager = new CourseManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LodeDepartment();
            }
        }

        public void LodeDepartment()
        {
            try
            {

                var subject = _courseManager.GetDepartmentId();
                dropDownDepartment.DataSource = subject;
                dropDownDepartment.DataTextField = "Department";
                dropDownDepartment.DataValueField = "Id";
                dropDownDepartment.DataBind();
                dropDownDepartment.SelectedIndex = -1;

            }
            catch (Exception e)
            {
                lblMessege.Text = e.Message;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dropDownDepartment.SelectedValue == "" || txtCourseCode.Text == ""||txtCourseName.Text=="")
                {
                    string validationMessage = "Please fillup Required fields";
                    lblMessege.Text = validationMessage;
                    return;
                }
                var isUserMobileExist = _courseManager.IsNameExist(txtCourseName.Text);
                if (isUserMobileExist)
                {
                    var validationMessage = "Departmnt Already Exist";
                    lblMessege.Text = validationMessage;
                    return;
                }
                var userInfo = new CourseModel();
                userInfo.DepartmentId = Convert.ToInt32(dropDownDepartment.SelectedValue);
                userInfo.CourseCode = txtCourseCode.Text;
                userInfo.CourseName = txtCourseName.Text;

                var isSave = _courseManager.Save(userInfo);
                if (isSave)
                {
                    RefreshField();
                    string successMessage = " Saved Successfully";
                    lblMessege.Text = successMessage;
                    lblMessege.ForeColor = Color.Green;
                    return;
                }
                string failMessage = "Fild Not Saved ";
                lblMessege.Text = failMessage;

            }
            catch (Exception exception)
            {
                lblMessege.Text = exception.Message;
            }
        }
        public void RefreshField()
        {
            txtCourseCode.Text = "";
            txtCourseName.Text = "";
        }
    }
}