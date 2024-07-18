using MyGuestApp.DAL;
using myHostApp.Models;

namespace myHostApp
{
    public partial class MainForm : Form
    {
        private Manager _guestManager;
        private List<GuestModel> _guestList;
        private FormHandler _formHandler;
        public MainForm(Manager guestManager, FormHandler handler)
        {
            InitializeComponent();
            _guestManager = guestManager;
            _formHandler = handler;
            _guestList = _guestManager.GetAllGuests();
            LoadNames();
        }

        private void LoadNames()
        {
            listBoxNames.Items.Clear();
            foreach (GuestModel guest in _guestList)
                listBoxNames.Items.Add(guest.GuestName);

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _formHandler.InitaliseForms(textBoxName.Text);

            string guestName = textBoxName.Text;
            if (string.IsNullOrEmpty(guestName))
            {
                MessageBox.Show("Please enter name!");
                return;
            }
            bool exists = _guestList.Any(guest => guest.GuestName == guestName);
            if (exists)
            {
                MessageBox.Show("You exist in the Name list");
                this.Close();
                _formHandler.ShowFirstform();
                return;
            }
            bool insertSuccess = _guestManager.InsertGuestReturnBoll(new GuestModel(0, guestName));
            if (insertSuccess==false) {

                MessageBox.Show("Faield to insert!");
                return;
            }
            this.Close();
            LoadNames();
            MessageBox.Show("Your name was added sucessfuly!");
            _formHandler.ShowFirstform();




        }

    }
}
