using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHostApp.Models
{
    public class GuestModel
    {
        public int GuestID { get; set; }
        public string GuestName { get; set; }

        public GuestModel(int guestId, string guestName)
        {
            GuestID = guestId;
            GuestName = guestName;
        }


        public GuestModel(DataRow row)
        {
            if (row == null || row["Name"] == null)
            {
                throw new ArgumentNullException(nameof(row));
            }
            GuestID = (int)row["ID"];
            GuestName = (string)row["Name"];
        }
    }
}
