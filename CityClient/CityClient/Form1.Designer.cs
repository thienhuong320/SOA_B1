namespace CityClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetAllCities = new Button();
            dataGridView1 = new DataGridView();
            btnGetCityByName = new Button();
            txtCityName = new TextBox();
            txtCountryCode = new TextBox();
            btnGetCitiesByCountry = new Button();
            btnGetCountryByCode = new Button();
            txtPopulationThreshold = new TextBox();
            btnGetCountriesByPopulation = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGetAllCities
            // 
            btnGetAllCities.Location = new Point(173, 63);
            btnGetAllCities.Name = "btnGetAllCities";
            btnGetAllCities.Size = new Size(131, 40);
            btnGetAllCities.TabIndex = 0;
            btnGetAllCities.Text = "AllCity";
            btnGetAllCities.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(343, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(420, 262);
            dataGridView1.TabIndex = 1;
            // 
            // btnGetCityByName
            // 
            btnGetCityByName.Location = new Point(193, 134);
            btnGetCityByName.Name = "btnGetCityByName";
            btnGetCityByName.Size = new Size(131, 40);
            btnGetCityByName.TabIndex = 2;
            btnGetCityByName.Text = "CityName";
            btnGetCityByName.UseVisualStyleBackColor = true;
            // 
            // txtCityName
            // 
            txtCityName.Location = new Point(12, 139);
            txtCityName.Name = "txtCityName";
            txtCityName.Size = new Size(175, 35);
            txtCityName.TabIndex = 3;
            // 
            // txtCountryCode
            // 
            txtCountryCode.Location = new Point(12, 244);
            txtCountryCode.Name = "txtCountryCode";
            txtCountryCode.Size = new Size(175, 35);
            txtCountryCode.TabIndex = 4;
            // 
            // btnGetCitiesByCountry
            // 
            btnGetCitiesByCountry.Location = new Point(193, 204);
            btnGetCitiesByCountry.Name = "btnGetCitiesByCountry";
            btnGetCitiesByCountry.Size = new Size(131, 40);
            btnGetCitiesByCountry.TabIndex = 5;
            btnGetCitiesByCountry.Text = "City-CTCode";
            btnGetCitiesByCountry.UseVisualStyleBackColor = true;
            // 
            // btnGetCountryByCode
            // 
            btnGetCountryByCode.Location = new Point(193, 269);
            btnGetCountryByCode.Name = "btnGetCountryByCode";
            btnGetCountryByCode.Size = new Size(131, 40);
            btnGetCountryByCode.TabIndex = 7;
            btnGetCountryByCode.Text = "CT-CTcode";
            btnGetCountryByCode.UseVisualStyleBackColor = true;
            // 
            // txtPopulationThreshold
            // 
            txtPopulationThreshold.Location = new Point(12, 336);
            txtPopulationThreshold.Name = "txtPopulationThreshold";
            txtPopulationThreshold.Size = new Size(175, 35);
            txtPopulationThreshold.TabIndex = 8;
            // 
            // btnGetCountriesByPopulation
            // 
            btnGetCountriesByPopulation.Location = new Point(193, 331);
            btnGetCountriesByPopulation.Name = "btnGetCountriesByPopulation";
            btnGetCountriesByPopulation.Size = new Size(131, 40);
            btnGetCountriesByPopulation.TabIndex = 9;
            btnGetCountriesByPopulation.Text = "Population";
            btnGetCountriesByPopulation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 618);
            Controls.Add(btnGetCountriesByPopulation);
            Controls.Add(txtPopulationThreshold);
            Controls.Add(btnGetCountryByCode);
            Controls.Add(btnGetCitiesByCountry);
            Controls.Add(txtCountryCode);
            Controls.Add(txtCityName);
            Controls.Add(btnGetCityByName);
            Controls.Add(dataGridView1);
            Controls.Add(btnGetAllCities);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetAllCities;
        private DataGridView dataGridView1;
        private Button btnGetCityByName;
        private TextBox txtCityName;
        private TextBox txtCountryCode;
        private Button btnGetCitiesByCountry;
        private Button btnGetCountryByCode;
        private TextBox txtPopulationThreshold;
        private Button btnGetCountriesByPopulation;
    }
}