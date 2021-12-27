
namespace Autoshow
{
    partial class MenuCustumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCustumer));
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDated = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNameMF = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonViewCont = new System.Windows.Forms.Button();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor.BackColor = System.Drawing.Color.Silver;
            this.panelColor.Controls.Add(this.buttonLogout);
            this.panelColor.Controls.Add(this.labelTime);
            this.panelColor.Controls.Add(this.labelDated);
            this.panelColor.Controls.Add(this.labelDate);
            this.panelColor.Controls.Add(this.labelNameMF);
            this.panelColor.Location = new System.Drawing.Point(-2, -4);
            this.panelColor.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(1182, 175);
            this.panelColor.TabIndex = 3;
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
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(14, 16);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(191, 71);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Text = "Выйти";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.Location = new System.Drawing.Point(451, 202);
            this.labelMenu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(296, 49);
            this.labelMenu.TabIndex = 5;
            this.labelMenu.Text = "Меню Клиента";
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonView.Location = new System.Drawing.Point(124, 307);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(408, 74);
            this.buttonView.TabIndex = 13;
            this.buttonView.Text = "Посмотреть машины";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(365, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 75);
            this.button1.TabIndex = 14;
            this.button1.Text = "Оформить заявку на договор";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonViewCont
            // 
            this.buttonViewCont.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewCont.Location = new System.Drawing.Point(625, 307);
            this.buttonViewCont.Name = "buttonViewCont";
            this.buttonViewCont.Size = new System.Drawing.Size(408, 74);
            this.buttonViewCont.TabIndex = 16;
            this.buttonViewCont.Text = "Посмотреть договор";
            this.buttonViewCont.UseVisualStyleBackColor = true;
            // 
            // MenuCustumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1179, 698);
            this.Controls.Add(this.buttonViewCont);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.panelColor);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MenuCustumer";
            this.Text = "MenuCustumer";
            this.Load += new System.EventHandler(this.MenuCustumer_Load);
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDated;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNameMF;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonViewCont;
    }
}