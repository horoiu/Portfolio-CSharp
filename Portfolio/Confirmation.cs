using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio
{
    public partial class Confirmation : Form
    {
        public Confirmation(string message)
        {
            InitializeComponent();
            labelConfirmation.Text = message;
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
        }
    }
}
