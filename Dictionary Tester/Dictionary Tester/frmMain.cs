using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_Tester
{
    public partial class frmMain : Form
    {
        private Dictionary<int, float> m_Dictionary;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                m_Dictionary = new Dictionary<int, float>();

                m_Dictionary.Add(1, 1.23f);
                m_Dictionary.Add(2, -0.5f);
                m_Dictionary.Add(3, 98.76f);

                float sName = m_Dictionary.Values.First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            float sName;

            if (m_Dictionary.TryGetValue((int)(nudKey.Value), out sName))
            {
                MessageBox.Show("The Name For Key " + nudKey.Value + " Is '" + sName + "'");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
