
namespace WindowsFormsApp2
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.roundBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.roundBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.userControl11 = new WindowsFormsApp2.UserControl1();
      ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // roundBindingSource1
      // 
      this.roundBindingSource1.DataSource = typeof(WindowsFormsApp2.round);
      // 
      // roundBindingSource
      // 
      this.roundBindingSource.DataSource = typeof(WindowsFormsApp2.round);
      // 
      // userControl11
      // 
      this.userControl11.BackShapeColor = System.Drawing.Color.Maroon;
      this.userControl11.Header = "label1";
      this.userControl11.LabelOne = "one";
      this.userControl11.Location = new System.Drawing.Point(189, 79);
      this.userControl11.Name = "userControl11";
      this.userControl11.Size = new System.Drawing.Size(296, 198);
      this.userControl11.TabIndex = 0;
      this.userControl11.Value = "Value";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(1187, 595);
      this.Controls.Add(this.userControl11);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource)).EndInit();
      this.ResumeLayout(false);

    }


    #endregion
    private System.Windows.Forms.BindingSource roundBindingSource;
    private System.Windows.Forms.BindingSource roundBindingSource1;
    private UserControl1 userControl11;
  }
}

