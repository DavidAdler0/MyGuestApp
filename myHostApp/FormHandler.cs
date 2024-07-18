using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGuestApp.DAL;

namespace myHostApp
{
    public class FormHandler
    {
        private Manager _guestManager;
        public List<CategoryForm> categoryList = new List<CategoryForm>();
        public int Index = 0;
        public FormHandler(Manager guestManager)
        {
            _guestManager = guestManager;
        }
        public List<CategoryForm> InitaliseForms(string guest)
        {
            DataTable categories = _guestManager.GetAllCategories();
            foreach (DataRow row in categories.Rows)
            {
                categoryList.Add(new CategoryForm(row["CategoryName"].ToString(),_guestManager, this, guest));
            }
            return categoryList;

        }
        public void ShowNextform()
        {
            categoryList[Index].Hide();
            Index++;
            if (Index > categoryList.Count()-1)
            {
                Index = 0;
            }
            categoryList[Index].Show();
        }
        public void ShowPrevform()
        {
            categoryList[Index].Hide();
            Index--;
            if (Index < 0)
            {
                Index = categoryList.Count-1;
            }
            categoryList[Index].Show();
        }
        public void ShowFirstform()
        {
            categoryList[0].Show();
        }
        public void ShowMainform()
        {
            MainForm main = new MainForm(_guestManager, this);
            main.Show();
        }
    }
}
