using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Services;

namespace NW
{
    public partial class Customers : Form
    {
        private readonly ICustomerService _customerSevice;
        private readonly IEmployeeService _employeeService;
        private readonly IProductService _productService;
        public Customers(
            ICustomerService customerSevice,
            IEmployeeService employeeService,
            IProductService productService)
        {
            InitializeComponent();
            _customerSevice = customerSevice;
            _employeeService = employeeService;
            _productService = productService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerDataGridView.DataSource = _customerSevice.GetAll();
        }
        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer currentCustomer = _customerSevice.Get(customerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            FillTextBoxes(currentCustomer);
        }
        private void customerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Customer currentCustomer = _customerSevice.Get(customerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            FillTextBoxes(currentCustomer);

        }
        private void FillTextBoxes(Customer customer)
        {
            cityTextBox.Text = customer.City;
            countryTextBox.Text = customer.Country;
            regionTextBox.Text = customer.Region;
            addressTextBox.Text = customer.Address;
            postalCodeTextBox.Text = customer.PostalCode;
            customerIDTextBox.Text = customer.CustomerID;
            companyNameTextBox.Text = customer.CompanyName;
            contactNameTextBox.Text = customer.ContactName;
            contactTitleTextBox.Text = customer.ContactTitle;
            faxTextBox.Text = customer.Fax;
            phoneTextBox.Text = customer.Phone;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer
            {
                CustomerID = customerIDTextBox.Text,
                City = cityTextBox.Text,
                Country = countryTextBox.Text,
                Region = regionTextBox.Text,
                Address = addressTextBox.Text,
                PostalCode = postalCodeTextBox.Text,
                CompanyName = companyNameTextBox.Text,
                ContactName = contactNameTextBox.Text,
                ContactTitle = contactTitleTextBox.Text,
                Fax = faxTextBox.Text,
                Phone = phoneTextBox.Text
            };
            _customerSevice.Add(newCustomer);
            _customerSevice.Save();
        }
    }
}
