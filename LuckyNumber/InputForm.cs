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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int day;
            int year;
            int siblings;

            bool tryDay = int.TryParse(dayBox.Text, out day);
            bool tryYear = int.TryParse(yearBox.Text, out year);
            bool trySiblings = int.TryParse(siblingsBox.Text, out siblings);

            if (tryDay && tryYear && trySiblings)
            {
                int result = ((day * year * siblings) - year) / day;
                if (result == 0) { Random rand = new Random(); result = rand.Next() / 10000000; }
                ResultForm results = new ResultForm(result);

                results.Show();
            }
            else
            {
                errorText.Visible = true;
            }
        }
    }
}
