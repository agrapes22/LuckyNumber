using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();

        }

        public ResultForm(int result)
        {
            InitializeComponent();
            numberText.Text = result.ToString();

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
