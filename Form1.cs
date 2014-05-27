using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MC1.C_;

namespace MC1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseConnect ketnoi = new DatabaseConnect();
            MessageBox.Show(ketnoi.StatusConnect + ":)))))))" + ketnoi.ErrorConnect);
        }

        
    }
}
