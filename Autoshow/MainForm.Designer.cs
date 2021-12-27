
namespace Autoshow
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNameMF = new System.Windows.Forms.Label();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.buttonViewInfo = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelinfo = new System.Windows.Forms.Label();
            this.labelHead = new System.Windows.Forms.Label();
            this.pictureBoxInformation = new System.Windows.Forms.PictureBox();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.panelColor.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor.BackColor = System.Drawing.Color.Silver;
            this.panelColor.Controls.Add(this.labelTime);
            this.panelColor.Controls.Add(this.labelDate);
            this.panelColor.Controls.Add(this.labelNameMF);
            this.panelColor.Location = new System.Drawing.Point(-3, -1);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(1184, 194);
            this.panelColor.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(973, 37);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(72, 27);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "время";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(940, 10);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(230, 27);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Здесь системная дата";
            // 
            // labelNameMF
            // 
            this.labelNameMF.AutoSize = true;
            this.labelNameMF.Font = new System.Drawing.Font("Times New Roman", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameMF.Location = new System.Drawing.Point(452, 37);
            this.labelNameMF.Name = "labelNameMF";
            this.labelNameMF.Size = new System.Drawing.Size(257, 114);
            this.labelNameMF.TabIndex = 0;
            this.labelNameMF.Text = "Автосалон\r\n   \"Элита\"";
            // 
            // buttonClient
            // 
            this.buttonClient.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClient.Location = new System.Drawing.Point(384, 306);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(389, 91);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Клиент";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmployee.Location = new System.Drawing.Point(384, 425);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(389, 91);
            this.buttonEmployee.TabIndex = 2;
            this.buttonEmployee.Text = "Сотрудник";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelect.Location = new System.Drawing.Point(320, 236);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(517, 40);
            this.labelSelect.TabIndex = 3;
            this.labelSelect.Text = "Зайди в систему под своей ролью";
            // 
            // buttonViewInfo
            // 
            this.buttonViewInfo.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewInfo.Location = new System.Drawing.Point(384, 547);
            this.buttonViewInfo.Name = "buttonViewInfo";
            this.buttonViewInfo.Size = new System.Drawing.Size(389, 91);
            this.buttonViewInfo.TabIndex = 4;
            this.buttonViewInfo.Text = "Просмотр без входа";
            this.buttonViewInfo.UseVisualStyleBackColor = true;
            this.buttonViewInfo.Click += new System.EventHandler(this.buttonViewInfo_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.LightGray;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.pictureBoxClose);
            this.panelInfo.Controls.Add(this.labelinfo);
            this.panelInfo.Controls.Add(this.labelHead);
            this.panelInfo.Location = new System.Drawing.Point(833, 143);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(334, 199);
            this.panelInfo.TabIndex = 6;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::Autoshow.Properties.Resources.icons8_cross_mark_48;
            this.pictureBoxClose.Location = new System.Drawing.Point(282, 6);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(47, 43);
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelinfo.Location = new System.Drawing.Point(9, 75);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(315, 57);
            this.labelinfo.TabIndex = 1;
            this.labelinfo.Text = "При нажатии на выбранную вами кнопку \r\nвы заходите под своей ролью и имеете \r\nраз" +
    "ные возможности работы с приложением";
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.labelHead.Location = new System.Drawing.Point(27, 18);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(249, 21);
            this.labelHead.TabIndex = 0;
            this.labelHead.Text = "Дополнительная информация";
            // 
            // pictureBoxInformation
            // 
            this.pictureBoxInformation.Image = global::Autoshow.Properties.Resources.icons8_high_importance_50;
            this.pictureBoxInformation.Location = new System.Drawing.Point(779, 348);
            this.pictureBoxInformation.Name = "pictureBoxInformation";
            this.pictureBoxInformation.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxInformation.TabIndex = 5;
            this.pictureBoxInformation.TabStop = false;
            this.pictureBoxInformation.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1179, 698);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.pictureBoxInformation);
            this.Controls.Add(this.buttonViewInfo);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.panelColor);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MainForm";
            this.Text = "AutoShow - MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelNameMF;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Button buttonViewInfo;
        private System.Windows.Forms.PictureBox pictureBoxInformation;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Label labelTime;
    }
}

