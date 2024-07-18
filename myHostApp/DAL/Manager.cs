using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using myHostApp.Models;

namespace MyGuestApp.DAL
{
    public class Manager
    {
        private readonly DBContext _dbContext;
        public Manager(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<GuestModel> GetAllGuests()
        {
            var guests = new List<GuestModel>();
            string query = "SELECT Id, Name FROM Guests";
            DataTable result = _dbContext.ExecuteQuery(query, null);
            foreach (DataRow row in result.Rows)
            {
                guests.Add(new GuestModel(row));
            }
            return guests;
        }
        public int InsertGuestReturnId(GuestModel model)
        {
            string query = @"INSERT INTO Guests (Name) 
                               VALUES(@name);
                               select SCOPE_IDENTITY()";
            SqlParameter[] parameters = [new SqlParameter("@name", model.GuestName)];
            int id = (int)_dbContext.ExecuteScalar(query, parameters);
            return id;
        }

        public bool InsertGuestReturnBoll(GuestModel model)
        {
            string query = @"INSERT INTO Guests (Name) 
                               VALUES(@name);";
            SqlParameter[] parameters = [new SqlParameter("@name", model.GuestName)];
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        // ?להעביר לקלאס אחר
        public DataTable GetAllCategories()
        {
            DataTable result = new DataTable();
            string query = "SELECT CategoryName FROM Categories";
            result = _dbContext.ExecuteQuery(query, null);
            return result;
        }
        public DataTable AllFoods(string categoryName, string guestName)
        {
            DataTable result = new DataTable();
            string query = @"select Name, FoodName from FoodOrders fo
                            inner Join Guests g on g.Id = fo.GuestID
                            inner Join Categories c on fo.CategoryID = c.CategoryID
                            where CategoryName = @categoryName and Name != @GuestName;";
            SqlParameter[] parameters = [new SqlParameter("@categoryName", categoryName), new SqlParameter("@GuestName", guestName)];
            result = _dbContext.ExecuteQuery(query, parameters);
            return result;
        }
        public DataTable YourFoods(string categoryName, string guestName)
        {
            DataTable result = new DataTable();
            string query = @"select Name, FoodName from FoodOrders fo
                            inner Join Guests g on g.Id = fo.GuestID
                            inner Join Categories c on fo.CategoryID = c.CategoryID
                            where CategoryName = @categoryName and Name = @GuestName;";
            SqlParameter[] parameters = [new SqlParameter("@categoryName", categoryName), new SqlParameter("@GuestName", guestName)];
            result = _dbContext.ExecuteQuery(query, parameters);
            return result;
        }
        public int CategoryIdByName(string categoryName)
        {
            string query = "SELECT CategoryID FROM Categories WHERE CategoryName = @categoryName";
            SqlParameter[] parameters = { new SqlParameter("@categoryName", categoryName) };

            DataTable result = _dbContext.ExecuteQuery(query, parameters);

            return (int)result.Rows[0]["CategoryID"];
        }
        public int GuestIdByName(string guestName)
        {
            string query = "SELECT ID FROM Guests WHERE Name = @GuestName";
            SqlParameter[] parameters = { new SqlParameter("@GuestName", guestName) };

            DataTable result = _dbContext.ExecuteQuery(query, parameters);

            return (int)result.Rows[0]["ID"];
        }
        public bool InsertFood(string gustName, string categoryName, string foodName)
        {
            int guestId = GuestIdByName(gustName);
            int categoryId = CategoryIdByName(categoryName);
            string query = "INSERT INTO FoodOrders (GuestID, CategoryID, FoodName) VALUES (@guestId,@categoryId, @foodName)";
            SqlParameter[] parameters = { new SqlParameter("@guestId", guestId), new SqlParameter("@categoryId", categoryId), new SqlParameter("@foodName", foodName) };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
