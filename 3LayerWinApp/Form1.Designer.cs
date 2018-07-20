using System.Configuration;


namespace _3LayerWinApp
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
            this.gvPhonesList = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvOrders = new System.Windows.Forms.DataGridView();
            this.btnNewPhone = new System.Windows.Forms.Button();
            this.btnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhonesList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPhonesList
            // 
            this.gvPhonesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhonesList.Location = new System.Drawing.Point(6, 31);
            this.gvPhonesList.Name = "gvPhonesList";
            this.gvPhonesList.Size = new System.Drawing.Size(524, 150);
            this.gvPhonesList.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 449);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNewPhone);
            this.tabPage1.Controls.Add(this.gvPhonesList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gvOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gvOrders
            // 
            this.gvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnCol});
            this.gvOrders.Location = new System.Drawing.Point(4, 4);
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.Size = new System.Drawing.Size(645, 188);
            this.gvOrders.TabIndex = 0;
            this.gvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrders_CellClick);
            this.gvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrders_CellContentClick);
            this.gvOrders.Click += new System.EventHandler(this.btnNewPhone_Click);
            // 
            // btnNewPhone
            // 
            this.btnNewPhone.Location = new System.Drawing.Point(9, 2);
            this.btnNewPhone.Name = "btnNewPhone";
            this.btnNewPhone.Size = new System.Drawing.Size(122, 23);
            this.btnNewPhone.TabIndex = 1;
            this.btnNewPhone.Text = "SaveChangesToDB";
            this.btnNewPhone.UseVisualStyleBackColor = true;
            this.btnNewPhone.Click += new System.EventHandler(this.btnNewPhone_Click);
            // 
            // btnCol
            // 
            this.btnCol.HeaderText = "ShowOrderItems";
            this.btnCol.Name = "btnCol";
            this.btnCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnCol.Text = "ShowOrderItems";
            this.btnCol.ToolTipText = "ShowOrderItems";
            this.btnCol.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ExampleDb";
            ((System.ComponentModel.ISupportInitialize)(this.gvPhonesList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.DataGridView gvPhonesList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gvOrders;
        private System.Windows.Forms.Button btnNewPhone;
        private System.Windows.Forms.DataGridViewButtonColumn btnCol;
    }
}

