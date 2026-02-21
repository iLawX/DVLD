using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class PersonDetails : Form
    {
        private int _id = -1;
        private string _nationalNo;
        public PersonDetails(int personID)
        {
            InitializeComponent();
            _id = personID;
        }
        public PersonDetails(string nationalNo)
        {
            InitializeComponent();
            _nationalNo = nationalNo;
        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            if (_id != -1)
            {
                PersonCard.LoadPerson(_id);
            }
            else
            {
                PersonCard.LoadPerson(_nationalNo);
            }
        }
    }
}
