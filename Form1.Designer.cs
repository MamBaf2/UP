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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVarR = new System.Windows.Forms.ComboBox();
            this.numAdults = new System.Windows.Forms.NumericUpDown();
            this.numChild = new System.Windows.Forms.NumericUpDown();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTypeV = new System.Windows.Forms.ComboBox();
            this.chkBel = new System.Windows.Forms.CheckBox();
            this.chkPit = new System.Windows.Forms.CheckBox();
            this.chkBag = new System.Windows.Forms.CheckBox();
            this.chkObrB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChild)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Red;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalc.Location = new System.Drawing.Point(245, 419);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(166, 51);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Оформить посадочный билет";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(257, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ЖДКасса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(46, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбор рейса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(46, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата и время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(46, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Кол-во взрослых";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(46, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Кол-во детей";
            // 
            // cmbVarR
            // 
            this.cmbVarR.Items.AddRange(new object[] {
            "Алапаевск -> Екатеринбург",
            "Москва-> Краснодар",
            "Верхняя Пышма -> Нижний тагил",
            "Санкт-Петербург -> Москва"});
            this.cmbVarR.Location = new System.Drawing.Point(127, 155);
            this.cmbVarR.Name = "cmbVarR";
            this.cmbVarR.Size = new System.Drawing.Size(163, 21);
            this.cmbVarR.TabIndex = 0;
            // 
            // numAdults
            // 
            this.numAdults.Location = new System.Drawing.Point(157, 240);
            this.numAdults.Name = "numAdults";
            this.numAdults.Size = new System.Drawing.Size(40, 20);
            this.numAdults.TabIndex = 3;
            // 
            // numChild
            // 
            this.numChild.Location = new System.Drawing.Point(157, 282);
            this.numChild.Name = "numChild";
            this.numChild.Size = new System.Drawing.Size(40, 20);
            this.numChild.TabIndex = 3;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(144, 194);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(333, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Тип вагона";
            // 
            // cmbTypeV
            // 
            this.cmbTypeV.Items.AddRange(new object[] {
            "купе",
            "СВ",
            "плацкарт",
            "для инвалидов"});
            this.cmbTypeV.Location = new System.Drawing.Point(403, 155);
            this.cmbTypeV.Name = "cmbTypeV";
            this.cmbTypeV.Size = new System.Drawing.Size(163, 21);
            this.cmbTypeV.TabIndex = 0;
            // 
            // chkBel
            // 
            this.chkBel.AutoSize = true;
            this.chkBel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkBel.Location = new System.Drawing.Point(49, 319);
            this.chkBel.Name = "chkBel";
            this.chkBel.Size = new System.Drawing.Size(249, 17);
            this.chkBel.TabIndex = 7;
            this.chkBel.Text = "Наличие белья (входит в стоимость билета)";
            this.chkBel.UseVisualStyleBackColor = false;
            // 
            // chkPit
            // 
            this.chkPit.AutoSize = true;
            this.chkPit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkPit.Location = new System.Drawing.Point(49, 342);
            this.chkPit.Name = "chkPit";
            this.chkPit.Size = new System.Drawing.Size(260, 17);
            this.chkPit.TabIndex = 7;
            this.chkPit.Text = "Наличие питания (входит в стоимость билета)";
            this.chkPit.UseVisualStyleBackColor = false;
            // 
            // chkBag
            // 
            this.chkBag.AutoSize = true;
            this.chkBag.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkBag.Location = new System.Drawing.Point(49, 365);
            this.chkBag.Name = "chkBag";
            this.chkBag.Size = new System.Drawing.Size(221, 17);
            this.chkBag.TabIndex = 7;
            this.chkBag.Text = "Наличие багажа (+1% к сумме билета)";
            this.chkBag.UseVisualStyleBackColor = false;
            // 
            // chkObrB
            // 
            this.chkObrB.AutoSize = true;
            this.chkObrB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkObrB.Location = new System.Drawing.Point(49, 388);
            this.chkObrB.Name = "chkObrB";
            this.chkObrB.Size = new System.Drawing.Size(227, 17);
            this.chkObrB.TabIndex = 7;
            this.chkObrB.Text = "Обратный билет (По стоимости билета)";
            this.chkObrB.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 482);
            this.Controls.Add(this.chkObrB);
            this.Controls.Add(this.chkBag);
            this.Controls.Add(this.chkPit);
            this.Controls.Add(this.chkBel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date);
            this.Controls.Add(this.numChild);
            this.Controls.Add(this.numAdults);
            this.Controls.Add(this.cmbTypeV);
            this.Controls.Add(this.cmbVarR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "ЖДКасса";
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVarR;
        private System.Windows.Forms.NumericUpDown numAdults;
        private System.Windows.Forms.NumericUpDown numChild;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTypeV;
        private System.Windows.Forms.CheckBox chkBel;
        private System.Windows.Forms.CheckBox chkPit;
        private System.Windows.Forms.CheckBox chkBag;
        private System.Windows.Forms.CheckBox chkObrB;
    }
}

