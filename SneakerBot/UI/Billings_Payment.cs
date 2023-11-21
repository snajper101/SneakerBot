using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerBot.UI
{
    public partial class Billings_Payment : UserControl
    {
        public Billings_Payment()
        {
            InitializeComponent();

            for (int i = 2019; i < 2101; i++)
            {
                Expir_Year_CB.Items.Add(i);
            }
        }
    }
}
