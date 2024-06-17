using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PROYECTO_FINAL_4SEM
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            this.dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.LightSteelBlue,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 8.25F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            this.dataGridView1.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.WhiteSmoke
            };
            // Form Design Customization
            this.BackColor = Color.LightGray; // Set background color
            this.ForeColor = Color.Black; // Set text color
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Set border style
            this.Padding = new Padding(10); // Set padding around controls

            // Layout Customization
            this.ClientSize = new Size(800, 600); // Set form size
            this.StartPosition = FormStartPosition.CenterScreen; // Center form on screen
            this.AutoScaleMode = AutoScaleMode.Font; // Adjust font size based on screen resolution

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Background Design Customization
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.LightBlue, 45f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=FABELA;Database=ProyectoFinal4Sem;Integrated Security=True;";
            sqlConnection = new SqlConnection(connectionString);

            // Ejemplo con autenticación integrada de Windows
            // string connectionString = "Server=localhost;Database=MyDatabase;Integrated Security=True;";
            // sqlConnection = new SqlConnection(connectionString);
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Employee", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void SaveDataToDatabase()
        {
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Employee", sqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void LoadCsv(string filePath)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading CSV: " + ex.Message);
            }
        }

        private void LoadXml(string filePath)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(filePath);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML: " + ex.Message);
            }
        }

        private void LoadJson(string filePath)
        {
            try
            {
                string jsonData = File.ReadAllText(filePath);
                DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(jsonData);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading JSON: " + ex.Message);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml|JSON files (*.json)|*.json"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                switch (extension)
                {
                    case ".csv":
                        LoadCsv(filePath);
                        break;
                    case ".xml":
                        LoadXml(filePath);
                        break;
                    case ".json":
                        LoadJson(filePath);
                        break;
                    default:
                        MessageBox.Show("Unsupported file format");
                        break;
                }
            }
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            SaveDataToDatabase();

        }

        private void btnLoadFromDatabase_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }
        private void SaveToXml(string filePath)
        {
            try
            {
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data to save!");
                    return;
                }

                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dataTable.Copy());
                dataSet.WriteXml(filePath);

                MessageBox.Show("Data saved successfully to XML: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to XML: " + ex.Message);
            }
        }

        private void SaveToCsv(string filePath)
        {
            try
            {
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data to save!");
                    return;
                }

                StringBuilder csvData = new StringBuilder();

                // Write header row
                foreach (DataColumn column in dataTable.Columns)
                {
                    csvData.Append(column.ColumnName + ",");
                }
                csvData.Remove(csvData.Length - 1, 1); // Remove trailing comma
                csvData.AppendLine();

                // Write data rows
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        string cellValue = row.ItemArray[i].ToString();
                        // Escape special characters for CSV (optional)
                        // cellValue = cellValue.Replace(",", "\",");
                        csvData.Append(cellValue + ",");
                    }
                    csvData.Remove(csvData.Length - 1, 1); // Remove trailing comma
                    csvData.AppendLine();
                }

                File.WriteAllText(filePath, csvData.ToString());

                MessageBox.Show("Data saved successfully to CSV: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to CSV: " + ex.Message);
            }
        }

        private void SaveToJson(string filePath)
        {
            try
            {
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data to save!");
                    return;
                }

                List<Dictionary<string, object>> jsonData = new List<Dictionary<string, object>>();
                foreach (DataRow row in dataTable.Rows)
                {
                    Dictionary<string, object> rowData = new Dictionary<string, object>();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        rowData.Add(dataTable.Columns[i].ColumnName, row.ItemArray[i]);
                    }
                    jsonData.Add(rowData);
                }

                string jsonString = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
                File.WriteAllText(filePath, jsonString);

                MessageBox.Show("Data saved successfully to JSON: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to JSON: " + ex.Message);

            }
        }

        private void btnSaveToJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Save data to XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveToJson(filePath);
            }
        }

        private void btnSaveToXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.Title = "Save data to XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveToXml(filePath);
            }
        }

        private void btnSaveToCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save data to CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveToCsv(filePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            // Create a new row with empty values
            DataRow newRow = dataTable.NewRow();
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                newRow[i] = DBNull.Value; // Set default values as appropriate
            }

            // Add the new row to the DataTable
            dataTable.Rows.Add(newRow);

            // Update the DataGridView to reflect the changes
            dataGridView1.Refresh();
        }
    }

}
