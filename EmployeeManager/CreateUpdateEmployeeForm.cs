using EmployeeManager.DTOs;
using EmployeeManager.Service;
using System;
using System.Windows.Forms;

namespace EmployeeManager
{
    public partial class CreateUpdateEmployeeForm : Form
    {

        Employee employeeToAddOrUpdate = new Employee();
        public CreateUpdateEmployeeForm()
        {
            InitializeComponent();
            btn_Create.Visible = true;
            btn_Update.Visible = false;
        }
        public CreateUpdateEmployeeForm(Employee employee) : this()
        {
            tb_Email.Text = employee.Email;
            tb_Gender.Text = employee.Gender;
            tb_Name.Text = employee.Name;
            tb_Status.Text = employee.Status;
            btn_Create.Visible = false;
            btn_Update.Visible = true;
            employeeToAddOrUpdate = employee;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            FillEmployeeObjectFromInputs();
            EmployeeService employeeService = new EmployeeService();
            var updatedEmployee = employeeService.UpdateEmployee(employeeToAddOrUpdate);
            if (updatedEmployee != null)
            {
                Alert("User updated successfully.");
                CleanUpUI();
            }
            else
            {
                Alert("An error occured during update, please check error log for more information.");
            }

        }

        private void Alert(string message)
        {
            MessageBox.Show(message);
        }

        private void FillEmployeeObjectFromInputs()
        {      
            employeeToAddOrUpdate.Name = tb_Name.Text;
            employeeToAddOrUpdate.Email = tb_Email.Text;
            employeeToAddOrUpdate.Gender = tb_Gender.Text;
            employeeToAddOrUpdate.Status = tb_Status.Text;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            FillEmployeeObjectFromInputs();
            EmployeeService employeeService = new EmployeeService();
            var createdEmployee = employeeService.CreateEmployee(employeeToAddOrUpdate);
            if (createdEmployee != null)
            {
                Alert("User created successfully.");
                CleanUpUI();
            }
            else
            {
                Alert("An error occured during creation, please check error log for more information.");
            }
        }
        private void CleanUpUI()
        {
            tb_Email.Text = string.Empty;
            tb_Gender.Text = string.Empty;
            tb_Name.Text = string.Empty;
            tb_Status.Text = string.Empty;
        }
    }
}
