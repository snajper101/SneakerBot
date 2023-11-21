using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerBot
{
    public partial class Tag : UserControl
    {
        Add_Task task;
        int i = 0;
        public Tag(Add_Task task,string Text, Color color, int i)
        {
            InitializeComponent();
            TagText.Text = Text;
            this.BackColor = color;
            this.task = task;
            this.i = i;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            task.Remove_Tag(i);
        }
    }
}
