using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.LocalDrivingLicense
{
    public partial class ApplicationDetails : Form
    {
        private int _id;
        public ApplicationDetails(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void ApplicationDetails_Load(object sender, EventArgs e)
        {
            LocalApplicationCard.LoadLocalApplication(_id);
        }
    }
}