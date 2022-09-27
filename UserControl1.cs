using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class UserControl1 : UserControl
  {
    List<round> __lst = null;
    public UserControl1()
    {
      InitializeComponent();
      //dataGridView1.Columns[0].Width = 80;
      //dataGridView1.Columns[1].Width = 60;
      //this.BoolList.Add(new BoolProperty() { Name = "one", Value="123" });
      this.dataGridView1.Font = new Font(this.Font.FontFamily, 7);
      __lst = new List<round>();

      __lst.Add(new round() { One = "Всего контроллеров", Two = "10 100"});
      __lst.Add(new round() { One = "Плохая связь", Two = "3000" });
      __lst.Add(new round() { One = "Нет связи", Two = "500"});
      this.dataGridView1.DataSource = __lst;

      dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;
      dataGridView1.AllowUserToAddRows = false;
      //dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
      dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }

    string __label_one = string.Empty;
    [Category("Custom")]
    [Browsable(true)]
    [Description("Set label one")]
    public string LabelOne
    {
      get
      {
        
        return __label_one;

      }
      set
      {


        __label_one= value;
        this.__lst[0].One = value;
        this.Invalidate();
      }
    }


    Color __color= Color.Black;

    [Category("Custom")]
    [Browsable(true)]
    [Description("Sets the color of the round ")]
    [Editor(typeof(System.Windows.Forms.Design.WindowsFormsComponentEditor), typeof(System.Drawing.Color))]
    public Color BackShapeColor
    {
      get
      {
        return __color;

      }
      set
      {

        this.__color = value;
        //this.groupBox1.ForeColor = __color;
        this.lblValue.ForeColor = __color;
        this.dataGridView1.DefaultCellStyle.ForeColor = __color;
        this.Invalidate();
      }
    }

    

    [Category("Custom")]
    [Browsable(true)]
    [Description("Sets header")]
    public string Header
    {
      get
      {
       
        return this.groupBox1.Text;

      }
      set
      {
        this.groupBox1.Text = value;
        this.Invalidate();
      }
    }

  

    [Category("Custom")]
    [Browsable(true)]
    [Description("Sets Value Big")]
    public string Value
    {
      get
      {
        return this.lblValue.Text;
      }
      set
      {
        this.lblValue.Text = value;
        this.Invalidate();
      }
    }

    //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    //{
    //  this.dataGridView1.ClearSelection();
    //}

   
  }

  

 
}
