using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptage_Spartiate
{
    public partial class frmSpartiates : Form
    {
        public frmSpartiates()
        {
            InitializeComponent();
        }

        private void frmSpartiates_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MessageBox.Show(decalage.ToString());
        }

        private void btnChiffrer_Click(object sender, EventArgs e)
        {
            char lettre;
            bool verif;
            string messageChiffrer = "";
            for (int i = txtMessageClair.TextLength - 1; i >= 0; i--)
            {
                lettre = txtMessageClair.Text[i];
                verif = lettre.Equals(' ');

                if (verif)
                {
                    
                } else
                {
                    messageChiffrer += lettre;
                }
                
            }
            txtMessageChiffre.Text = messageChiffrer;
        }
    }
}
