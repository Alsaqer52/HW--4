﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lecture_13_HW4
{
    public partial class Form1 : Form
    {
        private employee employee1;
        private employee employee2;
        private employee employee3;
        private List<employee> employees;
        private readonly object txtPassword;
        private readonly object txtName;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employee1 = new employee();

            employee1.Name = "mohammed";
            employee1.Password = "1020";

            employee2 = new employee();

            employee2.Name = "zero";
            employee2.Password = "0202";

            employee3 = new employee();

            employee3.Name = "omar";
            employee3.Password = "7040";

            employees = new List<employee>();

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            bool employeeFound = false;

            for (var i = 0; i < employees.Count; i++)
            {
                if (employees[i].Name == txtName.Text)
                {
                    employeeFound = true;

                    if (employees[i].Password == txtPassword.Text)
                    {
                        MessageBox.Show("Welcome " + employees[i].Name);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!");
                        break;
                    }
                }
            }

            if (!employeeFound)
            {
                MessageBox.Show("User Does Not Exist!!");
            }

        }


    }

    internal class employee
    {
        internal object Name;
        internal object Password;

        public employee()
        {
        }
    }
}

