using S.Core.Model;
using S.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace S.web
{
    public partial class Student : System.Web.UI.Page
    {
        readonly StudentManeger _studentManeger = new StudentManeger();
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

                var subject = _studentManeger.GetDepartmentId();
                dropdownDepartment.DataSource = subject;
                dropdownDepartment.DataTextField = "Department";
                dropdownDepartment.DataValueField = "Id";
                dropdownDepartment.DataBind();
                dropdownDepartment.SelectedIndex = -1;

            }
            catch (Exception e)
            {
                lblMessege.Text = e.Message;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("shuvohrs69@gmail.com", "jerinshuvo");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "National Polytechnic institute, Dhaka";
            msg.Body = " Dear Student " + txtName.Text + " Your Roll " + txtRoll.Text + " Your Department "+ dropdownDepartment.SelectedItem + " Your Course " +  dropdownCourse.SelectedItem;
            string toaddress = txtEmail.Text;
            msg.To.Add(toaddress);
            string fromaddress = "shuvohrs69@gmail.com";
            msg.From = new MailAddress(fromaddress);
            
                smtp.Send(msg);

           
            try
            {
                if (dropdownDepartment.SelectedValue == ""||dropdownCourse.SelectedValue=="" || txtName.Text == "" || txtRoll.Text == ""||txtEmail.Text=="")
                {
                    string validationMessage = "Please fillup Required fields";
                    lblMessege.Text = validationMessage;
                    return;
                }
                var isUserMobileExist = _studentManeger.IsNameExist(txtRoll.Text);
                if (isUserMobileExist)
                {
                    var validationMessage = "Roll Already Exist";
                    lblMessege.Text = validationMessage;
                    return;
                }
                var userInfo = new StudentModel();
                userInfo.DepartmentId = Convert.ToInt32(dropdownDepartment.SelectedValue);
                userInfo.CourseId = Convert.ToInt32(dropdownCourse.SelectedValue);
                userInfo.StudentName = txtName.Text;
                userInfo.Roll = txtRoll.Text;
                userInfo.Email = txtEmail.Text;

                var isSave = _studentManeger.Save(userInfo);
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
            dropdownDepartment.ClearSelection();
            dropdownCourse.ClearSelection();
            txtName.Text = "";
            txtRoll.Text = "";
            txtEmail.Text = "";
        }
    

        protected void dropdownDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dropdownDepartment.DataSource = null;
                dropdownCourse.DataSource = null;
                lblMessege.Text = "";
                if (dropdownDepartment.SelectedValue != null)
                {
                    var item = new StudentModel();
                    int Id = Convert.ToInt32(dropdownDepartment.SelectedValue);
                    var items = _studentManeger.GetAllId();
                    dropdownCourse.DataSource = items;
                    dropdownCourse.DataTextField = "CourseName";
                    dropdownCourse.DataValueField = "Id";
                    dropdownCourse.SelectedIndex = -1;
                    dropdownCourse.DataBind();
                }
            }
            catch (Exception en)
            {

                lblMessege.Text = en.Message;
            }

        }
    }
}