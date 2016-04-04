namespace SPtoolv2
{
    partial class sptool
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.isOnline = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Template = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.NameList = new System.Windows.Forms.TextBox();
            this.btn_cn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.siteUrl = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.isOnline);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Template);
            this.tabPage1.Controls.Add(this.lbl_titulo);
            this.tabPage1.Controls.Add(this.NameList);
            this.tabPage1.Controls.Add(this.btn_cn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.siteUrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // isOnline
            // 
            this.isOnline.AutoSize = true;
            this.isOnline.Location = new System.Drawing.Point(519, 9);
            this.isOnline.Name = "isOnline";
            this.isOnline.Size = new System.Drawing.Size(56, 17);
            this.isOnline.TabIndex = 8;
            this.isOnline.Text = "Online";
            this.isOnline.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Plantilla Personalizada ";
            // 
            // Template
            // 
            this.Template.FormattingEnabled = true;
            this.Template.Location = new System.Drawing.Point(129, 59);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(230, 21);
            this.Template.TabIndex = 5;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(10, 38);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(33, 13);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "Titulo";
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // NameList
            // 
            this.NameList.Location = new System.Drawing.Point(129, 31);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(230, 20);
            this.NameList.TabIndex = 3;
            // 
            // btn_cn
            // 
            this.btn_cn.Location = new System.Drawing.Point(129, 86);
            this.btn_cn.Name = "btn_cn";
            this.btn_cn.Size = new System.Drawing.Size(75, 23);
            this.btn_cn.TabIndex = 2;
            this.btn_cn.Text = "Crear";
            this.btn_cn.UseVisualStyleBackColor = true;
            this.btn_cn.Click += new System.EventHandler(this.btn_cn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sitio:";
            // 
            // siteUrl
            // 
            this.siteUrl.Location = new System.Drawing.Point(129, 6);
            this.siteUrl.Name = "siteUrl";
            this.siteUrl.Size = new System.Drawing.Size(384, 20);
            this.siteUrl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sptool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 303);
            this.Controls.Add(this.tabControl1);
            this.Name = "sptool";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox siteUrl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_cn;
        private System.Windows.Forms.TextBox NameList;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ComboBox Template;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isOnline;
        private System.Windows.Forms.Button button1;
    }
}

