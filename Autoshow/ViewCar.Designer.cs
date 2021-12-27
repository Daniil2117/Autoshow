
namespace Autoshow
{
    partial class ViewCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCar));
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.pictureCar = new System.Windows.Forms.PictureBox();
            this.labelSelectCar = new System.Windows.Forms.Label();
            this.labelSelectCountry = new System.Windows.Forms.Label();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.keymodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelcar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofissue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNameCar = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keymodel,
            this.modelcar,
            this.speed,
            this.fuel,
            this.transmission,
            this.enginetype,
            this.yearofissue,
            this.country});
            this.dataGridViewCar.Location = new System.Drawing.Point(23, 26);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.Size = new System.Drawing.Size(834, 451);
            this.dataGridViewCar.TabIndex = 0;
            this.dataGridViewCar.SelectionChanged += new System.EventHandler(this.dataGridViewCar_SelectionChanged);
            // 
            // pictureCar
            // 
            this.pictureCar.Location = new System.Drawing.Point(863, 26);
            this.pictureCar.Name = "pictureCar";
            this.pictureCar.Size = new System.Drawing.Size(368, 277);
            this.pictureCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCar.TabIndex = 1;
            this.pictureCar.TabStop = false;
            // 
            // labelSelectCar
            // 
            this.labelSelectCar.AutoSize = true;
            this.labelSelectCar.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectCar.Location = new System.Drawing.Point(12, 498);
            this.labelSelectCar.Name = "labelSelectCar";
            this.labelSelectCar.Size = new System.Drawing.Size(300, 40);
            this.labelSelectCar.TabIndex = 4;
            this.labelSelectCar.Text = "Поиск автомобиля:";
            // 
            // labelSelectCountry
            // 
            this.labelSelectCountry.AutoSize = true;
            this.labelSelectCountry.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectCountry.Location = new System.Drawing.Point(16, 557);
            this.labelSelectCountry.Name = "labelSelectCountry";
            this.labelSelectCountry.Size = new System.Drawing.Size(227, 40);
            this.labelSelectCountry.TabIndex = 5;
            this.labelSelectCountry.Text = "Введи страну:";
            // 
            // textBoxCar
            // 
            this.textBoxCar.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxCar.Location = new System.Drawing.Point(330, 499);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(341, 44);
            this.textBoxCar.TabIndex = 10;
            this.textBoxCar.TextChanged += new System.EventHandler(this.textBoxCar_TextChanged);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.textBoxCountry.Location = new System.Drawing.Point(330, 557);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(341, 44);
            this.textBoxCountry.TabIndex = 11;
            this.textBoxCountry.TextChanged += new System.EventHandler(this.textBoxCountry_TextChanged);
            // 
            // keymodel
            // 
            this.keymodel.HeaderText = "Номер модели";
            this.keymodel.Name = "keymodel";
            // 
            // modelcar
            // 
            this.modelcar.HeaderText = "Модель машины";
            this.modelcar.Name = "modelcar";
            // 
            // speed
            // 
            this.speed.HeaderText = "Скорость км/ч";
            this.speed.Name = "speed";
            // 
            // fuel
            // 
            this.fuel.HeaderText = "Расход на 100 км";
            this.fuel.Name = "fuel";
            // 
            // transmission
            // 
            this.transmission.HeaderText = "КП";
            this.transmission.Name = "transmission";
            // 
            // enginetype
            // 
            this.enginetype.HeaderText = "Тип двигателя";
            this.enginetype.Name = "enginetype";
            // 
            // yearofissue
            // 
            this.yearofissue.HeaderText = "Производство";
            this.yearofissue.Name = "yearofissue";
            // 
            // country
            // 
            this.country.HeaderText = "Страна производитель";
            this.country.Name = "country";
            // 
            // labelNameCar
            // 
            this.labelNameCar.AutoSize = true;
            this.labelNameCar.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCar.Location = new System.Drawing.Point(863, 323);
            this.labelNameCar.Name = "labelNameCar";
            this.labelNameCar.Size = new System.Drawing.Size(339, 40);
            this.labelNameCar.TabIndex = 12;
            this.labelNameCar.Text = "Название автомобиля";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(700, 499);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(191, 71);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ViewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 636);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelNameCar);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.labelSelectCountry);
            this.Controls.Add(this.labelSelectCar);
            this.Controls.Add(this.pictureCar);
            this.Controls.Add(this.dataGridViewCar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewCar";
            this.Text = "ViewCar";
            this.Load += new System.EventHandler(this.ViewCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.PictureBox pictureCar;
        private System.Windows.Forms.Label labelSelectCar;
        private System.Windows.Forms.Label labelSelectCountry;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn keymodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelcar;
        private System.Windows.Forms.DataGridViewTextBoxColumn speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofissue;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.Label labelNameCar;
        private System.Windows.Forms.Button buttonBack;
    }
}