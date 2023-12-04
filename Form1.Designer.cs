namespace УП
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
            this.btnCombin = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnPermut = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCombin = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblPermut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcm = new System.Windows.Forms.Label();
            this.lblcn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblam = new System.Windows.Forms.Label();
            this.lblan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblpn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCombin
            // 
            this.btnCombin.Location = new System.Drawing.Point(36, 45);
            this.btnCombin.Name = "btnCombin";
            this.btnCombin.Size = new System.Drawing.Size(103, 43);
            this.btnCombin.TabIndex = 0;
            this.btnCombin.Text = "Сочетание";
            this.btnCombin.UseVisualStyleBackColor = true;
            this.btnCombin.Click += new System.EventHandler(this.btnCombin_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(36, 112);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(103, 43);
            this.btnPlace.TabIndex = 0;
            this.btnPlace.Text = "Размещение";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnPermut
            // 
            this.btnPermut.Location = new System.Drawing.Point(36, 179);
            this.btnPermut.Name = "btnPermut";
            this.btnPermut.Size = new System.Drawing.Size(103, 43);
            this.btnPermut.TabIndex = 0;
            this.btnPermut.Text = "Перестановка";
            this.btnPermut.UseVisualStyleBackColor = true;
            this.btnPermut.Click += new System.EventHandler(this.btnPermut_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(286, 78);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(84, 20);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(286, 153);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(84, 20);
            this.txtM.TabIndex = 1;
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(263, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите значение n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(263, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите значение m";
            // 
            // lblCombin
            // 
            this.lblCombin.AutoSize = true;
            this.lblCombin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCombin.Location = new System.Drawing.Point(96, 292);
            this.lblCombin.Name = "lblCombin";
            this.lblCombin.Size = new System.Drawing.Size(17, 24);
            this.lblCombin.TabIndex = 3;
            this.lblCombin.Text = "*";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlace.Location = new System.Drawing.Point(96, 370);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(17, 24);
            this.lblPlace.TabIndex = 3;
            this.lblPlace.Text = "*";
            // 
            // lblPermut
            // 
            this.lblPermut.AutoSize = true;
            this.lblPermut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPermut.Location = new System.Drawing.Point(97, 435);
            this.lblPermut.Name = "lblPermut";
            this.lblPermut.Size = new System.Drawing.Size(17, 24);
            this.lblPermut.TabIndex = 3;
            this.lblPermut.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(69, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // lblcm
            // 
            this.lblcm.AutoSize = true;
            this.lblcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcm.Location = new System.Drawing.Point(49, 272);
            this.lblcm.Name = "lblcm";
            this.lblcm.Size = new System.Drawing.Size(22, 20);
            this.lblcm.TabIndex = 6;
            this.lblcm.Text = "m";
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcn.Location = new System.Drawing.Point(53, 305);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(18, 20);
            this.lblcn.TabIndex = 6;
            this.lblcn.Text = "n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(28, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(69, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "=";
            // 
            // lblam
            // 
            this.lblam.AutoSize = true;
            this.lblam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblam.Location = new System.Drawing.Point(49, 350);
            this.lblam.Name = "lblam";
            this.lblam.Size = new System.Drawing.Size(22, 20);
            this.lblam.TabIndex = 6;
            this.lblam.Text = "m";
            // 
            // lblan
            // 
            this.lblan.AutoSize = true;
            this.lblan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblan.Location = new System.Drawing.Point(53, 383);
            this.lblan.Name = "lblan";
            this.lblan.Size = new System.Drawing.Size(18, 20);
            this.lblan.TabIndex = 6;
            this.lblan.Text = "n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(28, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 31);
            this.label11.TabIndex = 4;
            this.label11.Text = "P";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(69, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "=";
            // 
            // lblpn
            // 
            this.lblpn.AutoSize = true;
            this.lblpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblpn.Location = new System.Drawing.Point(53, 448);
            this.lblpn.Name = "lblpn";
            this.lblpn.Size = new System.Drawing.Size(18, 20);
            this.lblpn.TabIndex = 6;
            this.lblpn.Text = "n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 481);
            this.Controls.Add(this.lblpn);
            this.Controls.Add(this.lblan);
            this.Controls.Add(this.lblam);
            this.Controls.Add(this.lblcn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblcm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPermut);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblCombin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnPermut);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.btnCombin);
            this.Name = "Form1";
            this.Text = "Элементы комбинаторики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCombin;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnPermut;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCombin;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblPermut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcm;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblam;
        private System.Windows.Forms.Label lblan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblpn;
    }
}

