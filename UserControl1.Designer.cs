
namespace WindowsFormsApp2
{
  partial class UserControl1
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

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.lblValue = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.roundBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.oneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.twoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // lblValue
      // 
      this.lblValue.AutoEllipsis = true;
      this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblValue.Location = new System.Drawing.Point(84, 18);
      this.lblValue.Name = "lblValue";
      this.lblValue.Size = new System.Drawing.Size(174, 46);
      this.lblValue.TabIndex = 0;
      this.lblValue.Text = "Value";
      this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dataGridView1);
      this.groupBox1.Controls.Add(this.lblValue);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(294, 159);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowDrop = true;
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.ColumnHeadersVisible = false;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oneDataGridViewTextBoxColumn,
            this.twoDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.roundBindingSource;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.Location = new System.Drawing.Point(3, 67);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidth = 51;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.dataGridView1.Size = new System.Drawing.Size(288, 75);
      this.dataGridView1.TabIndex = 1;
      // 
      // roundBindingSource
      // 
      this.roundBindingSource.DataSource = typeof(WindowsFormsApp2.round);
      // 
      // oneDataGridViewTextBoxColumn
      // 
      this.oneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.oneDataGridViewTextBoxColumn.DataPropertyName = "One";
      this.oneDataGridViewTextBoxColumn.HeaderText = "One";
      this.oneDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.oneDataGridViewTextBoxColumn.Name = "oneDataGridViewTextBoxColumn";
      // 
      // twoDataGridViewTextBoxColumn
      // 
      this.twoDataGridViewTextBoxColumn.DataPropertyName = "Two";
      this.twoDataGridViewTextBoxColumn.HeaderText = "Two";
      this.twoDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.twoDataGridViewTextBoxColumn.Name = "twoDataGridViewTextBoxColumn";
      this.twoDataGridViewTextBoxColumn.Width = 125;
      // 
      // UserControl1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.Controls.Add(this.groupBox1);
      this.Name = "UserControl1";
      this.Size = new System.Drawing.Size(294, 159);
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label lblValue;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.BindingSource roundBindingSource;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn oneDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn twoDataGridViewTextBoxColumn;
  }
}
