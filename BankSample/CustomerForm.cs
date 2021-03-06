﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankSample
{
    public partial class CustomerForm : Form
    {
        List<Account> accountList = new List<Account>() { };
        public Dictionary<string, Account> accountDictionary;
        //Bank bank = BankForm.bank;
        public Customer customer;
        public CustomerForm(Customer name)
        {
            InitializeComponent();
            if (rbtnChecking.Checked)
            {
                lblAccountProperties.Text = "Monthly Fee";
                
            }
            else if (rbtnSaving.Checked)
            {
                lblAccountProperties.Text = "Interest Rate";
            }

            if (File.Exists("Bank.xml"))
            {
                //bank.ReadFromXML();
                customer = name;
                Customer.GetCustomerAccounts(customer);
                ShowAccounts();
                if (lstAccounts.Items.Count > 0)
                {
                    lstAccounts.SelectedIndex = 0;
                }
            }
            else
            {
                ShowAccounts();
            }
        }
        public void ShowAccounts()
        {
            lstAccounts.Items.Clear();
            if (customer != null)
            {
                accountList = customer.GetAccounts();
            }
            accountDictionary = new Dictionary<string, Account> { };

            for (int i = 0; i < accountList.Count(); i++)
            {
                accountDictionary.Add(accountList[i].AccountNumber.ToString(), accountList[i]);
                lstAccounts.Items.Add(accountList[i].AccountNumber.ToString());
            }
            Bank.WriteToXML();
        }
        public void FillForm(string listItem)
        {
            txtFIrstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtAccountNumber.Text = accountDictionary[listItem].AccountNumber;
            txtBalance.Text = accountDictionary[listItem].Balance.ToString();

            string accountType = accountDictionary[listItem].GetType().ToString();

            if (accountDictionary[listItem] is CheckingAccount)
            {
                rbtnChecking.Checked = true;
                CheckingAccount checking = accountDictionary[listItem] as CheckingAccount;
                txtAccountProperties.Text = checking.MonthlyFee.ToString();
            }
            else if (accountDictionary[listItem] is SavingAccount)
            {
                rbtnSaving.Checked = true;
                SavingAccount saving = accountDictionary[listItem] as SavingAccount;
                txtAccountProperties.Text = saving.InterestRate.ToString();
            }
        }
        public void ClearTextFields()
        {
            txtAccountNumber.Clear();
            txtAccountProperties.Clear();
            txtBalance.Clear();
            txtFIrstName.Clear();
            txtLastName.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string accountNum = txtAccountNumber.Text;
            double properties = Convert.ToDouble(txtAccountProperties.Text);
            if (!accountDictionary.ContainsKey(accountNum))
            {
                if (rbtnSaving.Checked)
                {
                    SavingAccount saving = new SavingAccount(accountNum, properties);
                    customer.AddAccount(saving);
                }
                else if (rbtnChecking.Checked)
                {
                    CheckingAccount checking = new CheckingAccount(accountNum, properties);
                    customer.AddAccount(checking);
                }
                ShowAccounts();
                lstAccounts.SelectedIndex = accountList.Count() - 1;
            }
            else
            {
                MessageBox.Show("Customer with such number is already in the system! Try again...");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string accountNum = txtAccountNumber.Text;
            double properties = Convert.ToDouble(txtAccountProperties.Text);

            string listItem = lstAccounts.SelectedItem.ToString();
            int selectedIndex = lstAccounts.SelectedIndex;

            if (accountList.Count() > 0 && lstAccounts.SelectedIndex != null)
            {
                
                    customer.UpdateAccount(accountDictionary[listItem], accountNum, properties);
                    
                    ShowAccounts();
                    lstAccounts.SelectedIndex = accountList.Count() - 1;
                
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string listItem = lstAccounts.SelectedItem.ToString();

            if (accountDictionary.Count() > 0 && lstAccounts.SelectedIndex != null)
            {
                if (accountDictionary.ContainsKey(listItem))
                {
                    customer.DeleteAccount(accountDictionary[listItem]);
                }
                else
                {
                    MessageBox.Show("Account with such number doesn't exist in the system! Try again...");
                }

                ShowAccounts();
                ClearTextFields();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank.WriteToXML();
        }

        private void branchFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankForm bankForm = new BankForm();
            this.Hide();
            bankForm.Show();
        }
        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
            lblAccountProperties.Text = "Monthly Fee";
        }

        private void rbtnSaving_CheckedChanged(object sender, EventArgs e)
        {
            lblAccountProperties.Text = "Interest Rate";
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bank.WriteToXML();
            Application.Exit();
        }
        

        private void lstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedItem != null)
            {
                string listItem = lstAccounts.SelectedItem.ToString();
                FillForm(listItem);
            }
        }

       
    }
}
