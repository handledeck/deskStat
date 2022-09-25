
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
      this.roundBorderPanel1 = new UlcWin.ui.RoundBorderPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.lblValue = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.oneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.twoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roundBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.roundBorderPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // roundBorderPanel1
      // 
      this.roundBorderPanel1.BackShapeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
      this.roundBorderPanel1.Controls.Add(this.label1);
      this.roundBorderPanel1.Controls.Add(this.lblValue);
      this.roundBorderPanel1.Controls.Add(this.dataGridView1);
      this.roundBorderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.roundBorderPanel1.Location = new System.Drawing.Point(0, 0);
      this.roundBorderPanel1.Name = "roundBorderPanel1";
      this.roundBorderPanel1.RoundCorner = 5;
      this.roundBorderPanel1.ShapeBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
      this.roundBorderPanel1.ShapeBorderPadding = 3;
      this.roundBorderPanel1.ShapeBorderWitdh = 1;
      this.roundBorderPanel1.Size = new System.Drawing.Size(296, 198);
      this.roundBorderPanel1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoEllipsis = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(15, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(255, 18);
      this.label1.TabIndex = 2;
      this.label1.Text = "label1";
      // 
      // lblValue
      // 
      this.lblValue.AutoEllipsis = true;
      this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblValue.Location = new System.Drawing.Point(78, 46);
      this.lblValue.Name = "lblValue";
      this.lblValue.Size = new System.Drawing.Size(174, 46);
      this.lblValue.TabIndex = 0;
      this.lblValue.Text = "Value";
      this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.ColumnHeadersVisible = false;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oneDataGridViewTextBoxColumn,
            this.twoDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.roundBindingSource;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.Location = new System.Drawing.Point(19, 95);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidth = 51;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.dataGridView1.ShowCellErrors = false;
      this.dataGridView1.ShowCellToolTips = false;
      this.dataGridView1.ShowEditingIcon = false;
      this.dataGridView1.ShowRowErrors = false;
      this.dataGridView1.Size = new System.Drawing.Size(264, 82);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
      // 
      // oneDataGridViewTextBoxColumn
      // 
      this.oneDataGridViewTextBoxColumn.DataPropertyName = "One";
      this.oneDataGridViewTextBoxColumn.HeaderText = "One";
      this.oneDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.oneDataGridViewTextBoxColumn.Name = "oneDataGridViewTextBoxColumn";
      this.oneDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // twoDataGridViewTextBoxColumn
      // 
      this.twoDataGridViewTextBoxColumn.DataPropertyName = "Two";
      this.twoDataGridViewTextBoxColumn.HeaderText = "Two";
      this.twoDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.twoDataGridViewTextBoxColumn.Name = "twoDataGridViewTextBoxColumn";
      this.twoDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // roundBindingSource
      // 
      this.roundBindingSource.DataSource = typeof(WindowsFormsApp2.round);
      // 
      // UserControl1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.roundBorderPanel1);
      this.Name = "UserControl1";
      this.Size = new System.Drawing.Size(296, 198);
      this.roundBorderPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label lblValue;
    private System.Windows.Forms.DataGridViewTextBoxColumn oneDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn twoDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource roundBindingSource;
    private UlcWin.ui.RoundBorderPanel roundBorderPanel1;
    private System.Windows.Forms.Label label1;
  }
}
