using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _3LayerWinApp
{
    partial class Form1
    {
        string CS = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

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
            ((System.ComponentModel.ISupportInitialize)(this.gvPhonesList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPhonesList
            // 
            this.gvPhonesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhonesList.Location = new System.Drawing.Point(30, 27);
            this.gvPhonesList.Name = "gvPhonesList";
            this.gvPhonesList.Size = new System.Drawing.Size(240, 150);
            this.gvPhonesList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvPhonesList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvPhonesList)).EndInit();
            this.ResumeLayout(false);

            loadData();
        }

        #endregion

        private void loadData()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                connection.Open();
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM Phone", connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = selectCommand;
                DataSet myDataSet = new DataSet();
                adapter.Fill(myDataSet, "Ph");
                gvPhonesList.DataSource = myDataSet.Tables["Ph"];
            }
        }

        private System.Windows.Forms.DataGridView gvPhonesList;
    }
}

