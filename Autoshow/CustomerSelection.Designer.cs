
namespace Autoshow
{
    partial class CustomerSelection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSelection));
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDated = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNameMF = new System.Windows.Forms.Label();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxInformation = new System.Windows.Forms.PictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelinfo = new System.Windows.Forms.Label();
            this.labelHead = new System.Windows.Forms.Label();
            this.panelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor.BackColor = System.Drawing.Color.Silver;
            this.panelColor.Controls.Add(this.labelTime);
            this.panelColor.Controls.Add(this.labelDated);
            this.panelColor.Controls.Add(this.buttonBack);
            this.panelColor.Controls.Add(this.labelDate);
            this.panelColor.Controls.Add(this.labelNameMF);
            this.panelColor.Location = new System.Drawing.Point(2, -5);
            this.panelColor.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(1182, 201);
            this.panelColor.TabIndex = 1;
            this.panelColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelColor_Paint);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(973, 37);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(72, 27);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "время";
            // 
            // labelDated
            // 
            this.labelDated.AutoSize = true;
            this.labelDated.Location = new System.Drawing.Point(935, 14);
            this.labelDated.Name = "labelDated";
            this.labelDated.Size = new System.Drawing.Size(230, 27);
            this.labelDated.TabIndex = 8;
            this.labelDated.Text = "Здесь системная дата";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(10, 17);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(191, 71);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelDate.Location = new System.Drawing.Point(1950, 20);
            this.labelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(218, 58);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Здесь системная \r\nдата и время";
            // 
            // labelNameMF
            // 
            this.labelNameMF.AutoSize = true;
            this.labelNameMF.Font = new System.Drawing.Font("Times New Roman", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameMF.Location = new System.Drawing.Point(452, 37);
            this.labelNameMF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNameMF.Name = "labelNameMF";
            this.labelNameMF.Size = new System.Drawing.Size(257, 114);
            this.labelNameMF.TabIndex = 0;
            this.labelNameMF.Text = "Автосалон\r\n   \"Элита\"";
            // 
            // buttonAuto
            // 
            this.buttonAuto.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuto.Location = new System.Drawing.Point(401, 314);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(389, 91);
            this.buttonAuto.TabIndex = 2;
            this.buttonAuto.Text = "У меня есть доступ";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(401, 458);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(389, 91);
            this.buttonReg.TabIndex = 3;
            this.buttonReg.Text = "У меня нет доступа";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelect.Location = new System.Drawing.Point(330, 227);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(535, 40);
            this.labelSelect.TabIndex = 4;
            this.labelSelect.Text = "Выберите предложенные действия";
            // 
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // pictureBoxInformation
            // 
            this.pictureBoxInformation.Image = global::Autoshow.Properties.Resources.icons8_high_importance_50;
            this.pictureBoxInformation.Location = new System.Drawing.Point(796, 356);
            this.pictureBoxInformation.Name = "pictureBoxInformation";
            this.pictureBoxInformation.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxInformation.TabIndex = 6;
            this.pictureBoxInformation.TabStop = false;
            this.pictureBoxInformation.Click += new System.EventHandler(this.pictureBoxInformation_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.LightGray;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.pictureBoxClose);
            this.panelInfo.Controls.Add(this.labelinfo);
            this.panelInfo.Controls.Add(this.labelHead);
            this.panelInfo.Location = new System.Drawing.Point(851, 227);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(316, 171);
            this.panelInfo.TabIndex = 7;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::Autoshow.Properties.Resources.icons8_cross_mark_48;
            this.pictureBoxClose.Location = new System.Drawing.Point(264, 3);
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
            this.labelinfo.Location = new System.Drawing.Point(13, 73);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(241, 57);
            this.labelinfo.TabIndex = 1;
            this.labelinfo.Text = "Если у вас нет доступа\r\nпереходите на форму регистрации\r\nесли есть,войдите.";
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.labelHead.Location = new System.Drawing.Point(13, 18);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(249, 21);
            this.labelHead.TabIndex = 0;
            this.labelHead.Text = "Дополнительная информация";
            // 
            // CustomerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1179, 698);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.pictureBoxInformation);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.panelColor);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CustomerSelection";
            this.Text = "CustomerSelection";
            this.Load += new System.EventHandler(this.CustomerSelection_Load);
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNameMF;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.PictureBox pictureBoxInformation;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelDated;
        private System.Windows.Forms.Label labelTime;
    }
}