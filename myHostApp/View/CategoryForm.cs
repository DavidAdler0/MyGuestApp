using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGuestApp.DAL;
using myHostApp.Models;

namespace myHostApp
{
    public partial class CategoryForm : Form
    {
        private Manager _manager;
        public string _categoryName;
        private FormHandler _handler;
        public string _guestName;
        public CategoryForm(string categoryName,Manager manager, FormHandler handler, string guestname)
        {
            InitializeComponent();
            _categoryName = categoryName;
            _handler = handler;
            labelCategory.Text = categoryName;
            _manager = manager;
            _guestName = guestname;
            DataTable grid1 = new DataTable();
            grid1 = _manager.AllFoods(labelCategory.Text, _guestName);
            dataGridViewAll.DataSource = grid1;
            DataTable grid2 = new DataTable();
            grid2 = _manager.YourFoods(labelCategory.Text, _guestName);
            dataGridViewGuest.DataSource = grid2;






        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxFood.Enabled = true;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _handler.ShowNextform();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _handler.ShowPrevform();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {


            string foodName = textBoxFood.Text;
            if (string.IsNullOrEmpty(foodName))
            {
                MessageBox.Show("Please enter food to add!");
                return;
            }
            // להוסיף מניעת כפילות
            //bool exists = _guestList.Any(guest => guest.GuestName == guestName);
            //if (exists)
            //{
            //    MessageBox.Show("You exist in the Name list");
            //    this.Close();
            //    _formHandler.ShowFirstform();
            //    return;
            //}
            bool insertSuccess = _manager.InsertFood(_guestName, _categoryName, foodName);
            if (insertSuccess == false)
            {

                MessageBox.Show("Faield to insert!");
                return;
            }
            MessageBox.Show("You request has been adedd!");
            DataTable grid1 = new DataTable();
            grid1 = _manager.AllFoods(labelCategory.Text, _guestName);
            dataGridViewAll.DataSource = grid1;
            DataTable grid2 = new DataTable();
            grid2 = _manager.YourFoods(labelCategory.Text, _guestName);
            dataGridViewGuest.DataSource = grid2;



        }
    }
}
