using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_FINAL_4SEM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.btnLoadFromDatabase = new System.Windows.Forms.Button();
            this.btnSaveToXML = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaveToCSV = new System.Windows.Forms.Button();
            this.btnSaveToJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadFile.FlatAppearance.BorderSize = 0;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadFile.ForeColor = System.Drawing.Color.White;
            this.btnLoadFile.Location = new System.Drawing.Point(0, 306);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(152, 33);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "LoadFile";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveToDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveToDatabase.FlatAppearance.BorderSize = 0;
            this.btnSaveToDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToDatabase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveToDatabase.ForeColor = System.Drawing.Color.White;
            this.btnSaveToDatabase.Location = new System.Drawing.Point(731, 306);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(152, 37);
            this.btnSaveToDatabase.TabIndex = 2;
            this.btnSaveToDatabase.Text = "SaveToDatabase";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // btnLoadFromDatabase
            // 
            this.btnLoadFromDatabase.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadFromDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadFromDatabase.FlatAppearance.BorderSize = 0;
            this.btnLoadFromDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFromDatabase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadFromDatabase.ForeColor = System.Drawing.Color.White;
            this.btnLoadFromDatabase.Location = new System.Drawing.Point(551, 306);
            this.btnLoadFromDatabase.Name = "btnLoadFromDatabase";
            this.btnLoadFromDatabase.Size = new System.Drawing.Size(152, 37);
            this.btnLoadFromDatabase.TabIndex = 3;
            this.btnLoadFromDatabase.Text = "LoadFromDatabase";
            this.btnLoadFromDatabase.UseVisualStyleBackColor = false;
            this.btnLoadFromDatabase.Click += new System.EventHandler(this.btnLoadFromDatabase_Click);
            // 
            // btnSaveToXML
            // 
            this.btnSaveToXML.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveToXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveToXML.FlatAppearance.BorderSize = 0;
            this.btnSaveToXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToXML.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveToXML.ForeColor = System.Drawing.Color.White;
            this.btnSaveToXML.Location = new System.Drawing.Point(961, 391);
            this.btnSaveToXML.Name = "btnSaveToXML";
            this.btnSaveToXML.Size = new System.Drawing.Size(207, 88);
            this.btnSaveToXML.TabIndex = 4;
            this.btnSaveToXML.Text = "SAVETOXML";
            this.btnSaveToXML.UseVisualStyleBackColor = false;
            this.btnSaveToXML.Click += new System.EventHandler(this.btnSaveToXML_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(158, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveToCSV
            // 
            this.btnSaveToCSV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveToCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveToCSV.FlatAppearance.BorderSize = 0;
            this.btnSaveToCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveToCSV.ForeColor = System.Drawing.Color.White;
            this.btnSaveToCSV.Location = new System.Drawing.Point(961, 478);
            this.btnSaveToCSV.Name = "btnSaveToCSV";
            this.btnSaveToCSV.Size = new System.Drawing.Size(207, 88);
            this.btnSaveToCSV.TabIndex = 7;
            this.btnSaveToCSV.Text = "SAVETOCSV";
            this.btnSaveToCSV.UseVisualStyleBackColor = false;
            this.btnSaveToCSV.Click += new System.EventHandler(this.btnSaveToCSV_Click);
            // 
            // btnSaveToJson
            // 
            this.btnSaveToJson.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveToJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveToJson.FlatAppearance.BorderSize = 0;
            this.btnSaveToJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToJson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveToJson.ForeColor = System.Drawing.Color.White;
            this.btnSaveToJson.Location = new System.Drawing.Point(961, 306);
            this.btnSaveToJson.Name = "btnSaveToJson";
            this.btnSaveToJson.Size = new System.Drawing.Size(207, 88);
            this.btnSaveToJson.TabIndex = 8;
            this.btnSaveToJson.Text = "SAVETOJSON";
            this.btnSaveToJson.UseVisualStyleBackColor = false;
            this.btnSaveToJson.Click += new System.EventHandler(this.btnSaveToJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 558);
            this.Controls.Add(this.btnSaveToJson);
            this.Controls.Add(this.btnSaveToCSV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveToXML);
            this.Controls.Add(this.btnLoadFromDatabase);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "ADD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Button btnLoadFromDatabase;
        private System.Windows.Forms.Button btnSaveToXML;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveToCSV;
        private System.Windows.Forms.Button btnSaveToJson;
    }
}

