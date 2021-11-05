using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlmacenDeportivo;
using System.IO;

namespace UIAlmacenMapache
{
    public partial class FrmEmail : Form
    {
        public FrmEmail()
        {
            InitializeComponent();
            txtFacturaMail.Text = File.ReadAllText("factura.txt");
            
        }
        private void txtFacturaMail_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void FrmEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
