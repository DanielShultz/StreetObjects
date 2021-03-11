using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreetObjects
{
    public partial class Menu : Form
    {
        Result result1 = new Result();
        Result result2 = new Result();

        public Menu()
        {
            InitializeComponent();
            log1.Text = result1.log;
            log2.Text = result2.log;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Test1 test1 = new Test1(100);
            DialogResult result = test1.ShowDialog(this);
            result1.Modify(test1.mistakes, test1.rightAnswer);
            log1.Text = result1.log;
        }

        private void Start2_Click(object sender, EventArgs e)
        {
            Test1 test1 = new Test1(50);
            DialogResult result = test1.ShowDialog(this);
            result2.Modify(test1.mistakes, test1.rightAnswer);
            log2.Text = result2.log;
        }
    }
}
