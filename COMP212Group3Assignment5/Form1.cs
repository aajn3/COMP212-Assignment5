using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Group 3
 * Arlina Ramrattan, Neil Reading, Aaron Fernandes, Jay Clipperton
 * Assignment 4 - Ciphering Using Array List
*/
namespace COMP212Group3Assignment5
{
    public partial class Form1 : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private Cipher _cipher;

        // CONSTRUCTOR
        public Form1()
        {
            this._cipher = new Cipher();
            InitializeComponent();
        }

        // PRIVATE METHODS
        private void encryptBtn_Click(object sender, EventArgs e)
        {
            this.textBoxDecrypt.Text = "";
            foreach(char c in this._cipher.Encrypt(textBoxEncrypt.Text)){
                this.textBoxDecrypt.Text += c;
            }
        }

        private void dencryptBtn_Click(object sender, EventArgs e)
        {
            this.textBoxEncrypt.Text = "";
            foreach (char c in this._cipher.Decrypt(textBoxDecrypt.Text))
            {
                this.textBoxEncrypt.Text += c;
            }
        }

    }
}
