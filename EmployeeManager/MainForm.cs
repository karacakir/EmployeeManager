using EmployeeManager.Service;
using System;
using System.Windows.Forms;
using EmployeeManager.DTOs;
using System.IO;
using System.Collections.Generic;

namespace EmployeeManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BindEmployeesToEmployeesGrid();
        }

        private void BindEmployeesToEmployeesGrid()
        {
            ShowLoadingInfo(true);
            FillPageCombobox();
            LoadEmployees();
            ShowLoadingInfo(false);
        }

        private void ShowLoadingInfo(bool visible)
        {
           lbl_Loading.Visible = visible;
        }

        private void FillPageCombobox()
        {
            EmployeeService employeeService = new EmployeeService();
            int pageCount = employeeService.GetPageCount();
            int[] pages = new int[pageCount];
            for (int i = 0; i < pageCount; i++)
            {
                pages[i] = i + 1;
            }
            cmb_Page.DataSource = pages;
            cmb_Page.SelectedIndex = 0;
        }

        private EmployeeService LoadEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            var employees = employeeService.GetAllEmployees(cmb_Page.SelectedIndex + 1);
            EmployeesGrid.DataSource = employees;
            return employeeService;
        }

        private void EmployeesGrid_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (EmployeesGrid.SelectedRows.Count > 0)
            {
                deleteEmployeesStripMenuItem.Enabled = true;
                if (EmployeesGrid.SelectedRows.Count == 1)
                {
                    updateItemStripMenuItem.Enabled = true;
                }
                else
                {
                    updateItemStripMenuItem.Enabled = false;
                }
            }
            else
            {
                deleteEmployeesStripMenuItem.Enabled = false;
            }
        }

        private void deleteEmployeesStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoadingInfo(true);
            EmployeeService employeeService = new EmployeeService();
            bool deleted = false;
            foreach (DataGridViewRow employee in EmployeesGrid.SelectedRows)
            {
                deleted = employeeService.DeleteEmployee(int.Parse(employee.Cells[0].Value.ToString()));
            }
            if (deleted)
            {
                Alert("User(s) deleted successfully.");
                BindEmployeesToEmployeesGrid();
            }
            else
            {
                Alert("An error occured during deletion, please check error log for more information.");
            }

            ShowLoadingInfo(false);
        }

        private void updateItemStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            var selectedEmployee = EmployeesGrid.SelectedRows[0].DataBoundItem as Employee;
            CreateUpdateEmployeeForm updateEmployeeForm = new CreateUpdateEmployeeForm(selectedEmployee);
            updateEmployeeForm.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            BindEmployeesToEmployeesGrid();
        }

        private void btn_CreateNewEmployee_Click(object sender, EventArgs e)
        {
            CreateUpdateEmployeeForm createEmployeeForm = new CreateUpdateEmployeeForm();
            createEmployeeForm.Show();
        }
        private void Alert(string message)
        {
            MessageBox.Show(message);
        }

        private void cmb_Page_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowLoadingInfo(true);
            LoadEmployees();
            ShowLoadingInfo(false);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            ShowLoadingInfo(true);
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            if (Directory.Exists(folderBrowserDialog.SelectedPath))
            {
                EmployeeService employeeService = new EmployeeService();
                var fileName = employeeService.Export(folderBrowserDialog.SelectedPath, EmployeesGrid.DataSource as List<Employee>);
                if (string.IsNullOrWhiteSpace(fileName))
                    Alert("An error occured during export, please check error log for more information.");
                else
                    Alert($"Page exported successfully to:{fileName}");
            }
            ShowLoadingInfo(false);
           
        }
    }
}
