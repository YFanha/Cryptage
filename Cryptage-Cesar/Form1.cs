using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptage_Cesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool verificationDecalage(int decalage)
        {
            bool verif;

            if (decalage < 1 || decalage > 26) 
            {
                verif = false;
            } else
            {
                verif = true;
            }

            return verif;
        }

        private void btnChiffrer_Click(object sender, EventArgs e)
        {
            string message = txtMessageClair.Text;
            string messageChiffrer = "";
            int caractereDecimal; //stocker la valeur decimal de caractere
            char caractere; //Variable qui recupere chaque caractere un par un
            int nbrLettreAlpha = 26;
            int retourArriereMinuscule = 122; //lettre pour savoie quand faire le tour (revenir a la lettre a, b etc..) MINUSCULE
            int retourArriereMAJUSCULE = 90;//lettre pour savoie quand faire le tour (revenir a la lettre B, B etc..) MAJUSCUle
            bool lower;
            bool verifDecalage, verifValeurDecalage;
            int decalage;



            verifDecalage = int.TryParse(txtDecalage.Text, out decalage);
            verifValeurDecalage = verificationDecalage(decalage);

            if (!verifDecalage)
            {
                MessageBox.Show("Veuillez indiquer le décalage.");
            }
            else
            {
                if (verifValeurDecalage)
                {
                    for (int i = 0; i < txtMessageClair.TextLength; i++)
                    {
                        caractere = txtMessageClair.Text[i]; //assigner la valeur du message en clair lettre par lettre

                        if (caractere.Equals(' '))
                        {

                        }
                        else
                        {
                            caractereDecimal = caractere; //conversion de la valeur du caractere en décimal

                            lower = char.IsLower(caractere); //Verifier si maj ou minuscules

                            if (caractereDecimal + decalage > retourArriereMAJUSCULE && lower == false) //majuscule
                            {
                                caractereDecimal = (caractereDecimal + decalage) - nbrLettreAlpha; //üüüü
                            }
                            else if (caractereDecimal + decalage > retourArriereMinuscule && lower == true) //minuscule
                            {
                                caractereDecimal = (caractereDecimal + decalage) - nbrLettreAlpha; //üüü
                            }
                            else
                            {
                                caractereDecimal += decalage;
                            }
                            caractere = (char)caractereDecimal; // tranformer la valeur décimal en caractère
                        }
                        messageChiffrer += caractere;
                    }
                    txtMessageChiffrer.Text = messageChiffrer;
                }
                else
                {
                    MessageBox.Show("La valeur du décalage doit être entre 1 et 26.");
                }
            }                     
        }

        private void txtDecalage_TextChanged(object sender, EventArgs e)
        {
            bool verif;
            verif = int.TryParse(txtDecalage.Text, out _);

            if (!verif && txtDecalage.Text != "")
            {
                MessageBox.Show("Veuillez ne rentrez qu'un nombre entre 1 et 26");
            }
        }

        private void txtMessageChiffrer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDechiffrer_Click(object sender, EventArgs e)
        {
            string message = txtMessageClair.Text;
            string messageChiffrer = "";
            int caractereDecimal; //stocker la valeur decimal de caractere
            char caractere; //Variable qui recupere chaque caractere un par un
            int nbrLettreAlpha = 26;
            int retourArriereMinuscule = 112; //lettre pour savoie quand faire le tour (revenir a la lettre a, b etc..) MINUSCULE
            int retourArriereMAJUSCULE = 80;//lettre pour savoie quand faire le tour (revenir a la lettre B, B etc..) MAJUSCUle
            bool lower;
            bool verifDecalage, verifValeurDecalage;
            int decalage;



            verifDecalage = int.TryParse(txtDecalage.Text, out decalage);
            verifValeurDecalage = verificationDecalage(decalage);

            if (!verifDecalage)
            {
                MessageBox.Show("Veuillez indiquer le décalage.");
            }
            else
            {
                if (verifValeurDecalage)
                {
                    for (int i = 0; i < txtMessageChiffrer.TextLength; i++)
                    {
                        caractere = txtMessageChiffrer.Text[i]; //assigner la valeur du message en clair lettre par lettre

                        if (caractere.Equals(' '))
                        {

                        }
                        else
                        {
                            caractereDecimal = caractere; //conversion de la valeur du caractere en décimal

                            lower = char.IsLower(caractere); //Verifier si maj ou minuscules

                            if (caractereDecimal - decalage < 65  && lower == false) //majuscule
                            {
                                caractereDecimal = (caractereDecimal - decalage) + nbrLettreAlpha; 
                            }
                            else if (caractereDecimal - decalage < 97 && lower == true) //minuscule
                            {
                                caractereDecimal = (caractereDecimal - decalage) + nbrLettreAlpha; 
                            }
                            else
                            {
                                caractereDecimal -= decalage;
                            }
                            caractere = (char)caractereDecimal; // tranformer la valeur décimal en caractère
                        }
                        messageChiffrer += caractere;
                    }
                    txtMessageClair.Text = messageChiffrer;
                }
                else
                {
                    MessageBox.Show("La valeur du décalage doit être entre 1 et 26.");
                }
            }
        }
    }
}
