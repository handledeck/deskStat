using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      List<round> lst = new List<round>();
      //dataGridView1.AutoResizeColumns();

      lst.Add(new round()
      {
        One = "111111111111111111111111111111111",
        Two = "244444444444442222222222222222222222"
      });
      lst.Add(new round()
      {
        One = "111111111111111111111111111111111",
        Two = "244444444444442222222222222222222222"
      });
      lst.Add(new round()
      {
        One = "111111111111111111111111111111111",
        Two = "244444444444442222222222222222222222"
      });
     
     
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
      //this.dataGridView1.ClearSelection();
    }
  }
}
