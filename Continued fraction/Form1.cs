using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Continued_fraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<BigInt> q = new List<BigInt>();
            List<BigInt> r = new List<BigInt>();

            r.Add(new BigInt(a1.Text));
            r.Add(new BigInt(a2.Text));

            int i = 0;

            while (r[i + 1] > BigInt.zero)
            {
                q.Add(r[i] / r[i+1]);
                r.Add(r[i] % r[i + 1]);
                i++;
            }

            result.Clear();

            for (int k = 0; k < q.Count; k++)
            {
                result.AppendText(q[k].ToString() + "\n");
            }
        }
    }
}
