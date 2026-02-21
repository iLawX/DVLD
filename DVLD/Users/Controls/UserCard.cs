using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD.Users.Controls
{
    public partial class UserCard : UserControl
    {
        private User user = new User();
        public User User { get { return user; } }
        public int UserID { get { return user.UserID; } }
        public UserCard()
        {
            InitializeComponent();
        }
        public void ResetCard()
        {
            PersonCard.ResetCard();
            ID.Clear();
            Username.Clear();
            IsActive.Clear();

            user.UserID = -1;
        }
        public void LoadUser(int userID)
        {
            user = User.GetByID(userID);

            if (user == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetCard();
                return;
            }

            PersonCard.LoadPerson(user.PersonID);
            ID.Text = user.UserID.ToString();
            Username.Text = user.Username;
            IsActive.Text = user.IsActive ? "Yes" : "No";
        }
    }
}
