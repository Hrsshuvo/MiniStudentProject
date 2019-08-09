using S.Core.Model;
using S.Persistance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S.web
{
    public partial class Department : System.Web.UI.Page
    {
        readonly DepartmentManager _departmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenarateAutoId();
            }
        }

        public void GenarateAutoId()
        {
            var subject = _departmentManager.GenarateAutoId();
            DataTable dt = new DataTable();
            txtCode.Text = dt.Rows[0][0].ToString();


        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Text == "" || txtDepartment.Text == "" )
                {
                    string validationMessage = "Please fillup Required fields";
                    lblMessege.Text = validationMessage;
                    return;
                }
                var isUserMobileExist = _departmentManager.IsNameExist(txtDepartment.Text);
                if (isUserMobileExist)
                {
                    var validationMessage = "Departmnt Already Exist";
                    lblMessege.Text = validationMessage;
                    return;
                }
                var userInfo = new DepartmentModel();
                userInfo.Code = txtCode.Text;
                userInfo.Department = txtDepartment.Text;
               
                var isSave = _departmentManager.Save(userInfo);
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
           txtCode.Text = txtCode.Text = "";
        }
    }
}
