
namespace BestOil
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxSumOil = new System.Windows.Forms.GroupBox();
            this.lbSumOil = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantityOil = new System.Windows.Forms.TextBox();
            this.lbOil = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.comboBoxOil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbQuantCola = new System.Windows.Forms.TextBox();
            this.tbPriceCola = new System.Windows.Forms.TextBox();
            this.tbQuantChips = new System.Windows.Forms.TextBox();
            this.tbPriceChips = new System.Windows.Forms.TextBox();
            this.tbQuantHotDog = new System.Windows.Forms.TextBox();
            this.tbPriceHotDog = new System.Windows.Forms.TextBox();
            this.tbQuantHamb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPriceHamb = new System.Windows.Forms.TextBox();
            this.lbChips = new System.Windows.Forms.Label();
            this.lbCola = new System.Windows.Forms.Label();
            this.lbHotdog = new System.Windows.Forms.Label();
            this.lbHamburg = new System.Windows.Forms.Label();
            this.groupBoxSumShop = new System.Windows.Forms.GroupBox();
            this.lbSumShop = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxToPay = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbToPay = new System.Windows.Forms.Label();
            this.btToPay = new System.Windows.Forms.Button();
            this.oilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBoxSumOil.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSumShop.SuspendLayout();
            this.groupBoxToPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.groupBoxSumOil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbQuantityOil);
            this.groupBox1.Controls.Add(this.lbOil);
            this.groupBox1.Controls.Add(this.lbQuantity);
            this.groupBox1.Controls.Add(this.comboBoxOil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil";
            // 
            // groupBoxSumOil
            // 
            this.groupBoxSumOil.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSumOil.Controls.Add(this.lbSumOil);
            this.groupBoxSumOil.Controls.Add(this.label2);
            this.groupBoxSumOil.Location = new System.Drawing.Point(38, 198);
            this.groupBoxSumOil.Name = "groupBoxSumOil";
            this.groupBoxSumOil.Size = new System.Drawing.Size(153, 76);
            this.groupBoxSumOil.TabIndex = 9;
            this.groupBoxSumOil.TabStop = false;
            this.groupBoxSumOil.Text = "Sum";
            // 
            // lbSumOil
            // 
            this.lbSumOil.AutoSize = true;
            this.lbSumOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumOil.Location = new System.Drawing.Point(25, 33);
            this.lbSumOil.Name = "lbSumOil";
            this.lbSumOil.Size = new System.Drawing.Size(87, 31);
            this.lbSumOil.TabIndex = 11;
            this.lbSumOil.Text = "00,00";
            this.lbSumOil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSumOil.Click += new System.EventHandler(this.lbSumOil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "hrn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "liters";
            // 
            // tbQuantityOil
            // 
            this.tbQuantityOil.Location = new System.Drawing.Point(69, 144);
            this.tbQuantityOil.Multiline = true;
            this.tbQuantityOil.Name = "tbQuantityOil";
            this.tbQuantityOil.Size = new System.Drawing.Size(120, 20);
            this.tbQuantityOil.TabIndex = 7;
            this.tbQuantityOil.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbOil
            // 
            this.lbOil.AutoSize = true;
            this.lbOil.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOil.Location = new System.Drawing.Point(18, 41);
            this.lbOil.Name = "lbOil";
            this.lbOil.Size = new System.Drawing.Size(30, 19);
            this.lbOil.TabIndex = 1;
            this.lbOil.Text = "Oil";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuantity.Location = new System.Drawing.Point(0, 144);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(72, 19);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Quantity";
            // 
            // comboBoxOil
            // 
            this.comboBoxOil.FormattingEnabled = true;
            this.comboBoxOil.Items.AddRange(new object[] {
            "A 95",
            "A 92",
            "Disel",
            "Gaz"});
            this.comboBoxOil.Location = new System.Drawing.Point(68, 39);
            this.comboBoxOil.Name = "comboBoxOil";
            this.comboBoxOil.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOil.TabIndex = 5;
            this.comboBoxOil.SelectedIndexChanged += new System.EventHandler(this.comboBoxOil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "hrn";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(69, 84);
            this.tbPrice.Multiline = true;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(120, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPrice.Location = new System.Drawing.Point(18, 87);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 19);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            this.lbPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.tbQuantCola);
            this.groupBox2.Controls.Add(this.tbPriceCola);
            this.groupBox2.Controls.Add(this.tbQuantChips);
            this.groupBox2.Controls.Add(this.tbPriceChips);
            this.groupBox2.Controls.Add(this.tbQuantHotDog);
            this.groupBox2.Controls.Add(this.tbPriceHotDog);
            this.groupBox2.Controls.Add(this.tbQuantHamb);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbPriceHamb);
            this.groupBox2.Controls.Add(this.lbChips);
            this.groupBox2.Controls.Add(this.lbCola);
            this.groupBox2.Controls.Add(this.lbHotdog);
            this.groupBox2.Controls.Add(this.lbHamburg);
            this.groupBox2.Controls.Add(this.groupBoxSumShop);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shop";
            // 
            // tbQuantCola
            // 
            this.tbQuantCola.Location = new System.Drawing.Point(179, 140);
            this.tbQuantCola.Multiline = true;
            this.tbQuantCola.Name = "tbQuantCola";
            this.tbQuantCola.Size = new System.Drawing.Size(39, 20);
            this.tbQuantCola.TabIndex = 26;
            this.tbQuantCola.TextChanged += new System.EventHandler(this.tbQuantHamb_TextChanged);
            // 
            // tbPriceCola
            // 
            this.tbPriceCola.Location = new System.Drawing.Point(100, 140);
            this.tbPriceCola.Multiline = true;
            this.tbPriceCola.Name = "tbPriceCola";
            this.tbPriceCola.Size = new System.Drawing.Size(39, 20);
            this.tbPriceCola.TabIndex = 25;
            this.tbPriceCola.Text = "15";
            // 
            // tbQuantChips
            // 
            this.tbQuantChips.Location = new System.Drawing.Point(179, 104);
            this.tbQuantChips.Multiline = true;
            this.tbQuantChips.Name = "tbQuantChips";
            this.tbQuantChips.Size = new System.Drawing.Size(39, 20);
            this.tbQuantChips.TabIndex = 24;
            this.tbQuantChips.TextChanged += new System.EventHandler(this.tbQuantHamb_TextChanged);
            // 
            // tbPriceChips
            // 
            this.tbPriceChips.Location = new System.Drawing.Point(100, 104);
            this.tbPriceChips.Multiline = true;
            this.tbPriceChips.Name = "tbPriceChips";
            this.tbPriceChips.Size = new System.Drawing.Size(39, 20);
            this.tbPriceChips.TabIndex = 23;
            this.tbPriceChips.Text = "20";
            // 
            // tbQuantHotDog
            // 
            this.tbQuantHotDog.Location = new System.Drawing.Point(179, 68);
            this.tbQuantHotDog.Multiline = true;
            this.tbQuantHotDog.Name = "tbQuantHotDog";
            this.tbQuantHotDog.Size = new System.Drawing.Size(39, 20);
            this.tbQuantHotDog.TabIndex = 22;
            this.tbQuantHotDog.TextChanged += new System.EventHandler(this.tbQuantHamb_TextChanged);
            // 
            // tbPriceHotDog
            // 
            this.tbPriceHotDog.Location = new System.Drawing.Point(100, 68);
            this.tbPriceHotDog.Multiline = true;
            this.tbPriceHotDog.Name = "tbPriceHotDog";
            this.tbPriceHotDog.Size = new System.Drawing.Size(39, 20);
            this.tbPriceHotDog.TabIndex = 21;
            this.tbPriceHotDog.Text = "25";
            // 
            // tbQuantHamb
            // 
            this.tbQuantHamb.Location = new System.Drawing.Point(179, 32);
            this.tbQuantHamb.Multiline = true;
            this.tbQuantHamb.Name = "tbQuantHamb";
            this.tbQuantHamb.Size = new System.Drawing.Size(39, 20);
            this.tbQuantHamb.TabIndex = 20;
            this.tbQuantHamb.TextChanged += new System.EventHandler(this.tbQuantHamb_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(166, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(96, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Price";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbPriceHamb
            // 
            this.tbPriceHamb.Location = new System.Drawing.Point(100, 32);
            this.tbPriceHamb.Multiline = true;
            this.tbPriceHamb.Name = "tbPriceHamb";
            this.tbPriceHamb.Size = new System.Drawing.Size(39, 20);
            this.tbPriceHamb.TabIndex = 16;
            this.tbPriceHamb.Text = "35";
            // 
            // lbChips
            // 
            this.lbChips.AutoSize = true;
            this.lbChips.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChips.Location = new System.Drawing.Point(32, 103);
            this.lbChips.Name = "lbChips";
            this.lbChips.Size = new System.Drawing.Size(48, 19);
            this.lbChips.TabIndex = 14;
            this.lbChips.Text = "Chips";
            // 
            // lbCola
            // 
            this.lbCola.AutoSize = true;
            this.lbCola.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCola.Location = new System.Drawing.Point(39, 141);
            this.lbCola.Name = "lbCola";
            this.lbCola.Size = new System.Drawing.Size(41, 19);
            this.lbCola.TabIndex = 13;
            this.lbCola.Text = "Cola";
            // 
            // lbHotdog
            // 
            this.lbHotdog.AutoSize = true;
            this.lbHotdog.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHotdog.Location = new System.Drawing.Point(20, 67);
            this.lbHotdog.Name = "lbHotdog";
            this.lbHotdog.Size = new System.Drawing.Size(64, 19);
            this.lbHotdog.TabIndex = 12;
            this.lbHotdog.Text = "HotDog";
            // 
            // lbHamburg
            // 
            this.lbHamburg.AutoSize = true;
            this.lbHamburg.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHamburg.Location = new System.Drawing.Point(2, 33);
            this.lbHamburg.Name = "lbHamburg";
            this.lbHamburg.Size = new System.Drawing.Size(92, 19);
            this.lbHamburg.TabIndex = 11;
            this.lbHamburg.Text = "Hamburger";
            this.lbHamburg.Click += new System.EventHandler(this.lbHamburg_Click);
            // 
            // groupBoxSumShop
            // 
            this.groupBoxSumShop.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSumShop.Controls.Add(this.lbSumShop);
            this.groupBoxSumShop.Controls.Add(this.label5);
            this.groupBoxSumShop.Location = new System.Drawing.Point(55, 198);
            this.groupBoxSumShop.Name = "groupBoxSumShop";
            this.groupBoxSumShop.Size = new System.Drawing.Size(153, 76);
            this.groupBoxSumShop.TabIndex = 10;
            this.groupBoxSumShop.TabStop = false;
            this.groupBoxSumShop.Text = "Sum";
            // 
            // lbSumShop
            // 
            this.lbSumShop.AutoSize = true;
            this.lbSumShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSumShop.Location = new System.Drawing.Point(25, 33);
            this.lbSumShop.Name = "lbSumShop";
            this.lbSumShop.Size = new System.Drawing.Size(87, 31);
            this.lbSumShop.TabIndex = 11;
            this.lbSumShop.Text = "00,00";
            this.lbSumShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSumShop.Click += new System.EventHandler(this.lbSumShop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "hrn";
            // 
            // groupBoxToPay
            // 
            this.groupBoxToPay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxToPay.Controls.Add(this.label6);
            this.groupBoxToPay.Controls.Add(this.lbToPay);
            this.groupBoxToPay.Controls.Add(this.btToPay);
            this.groupBoxToPay.Location = new System.Drawing.Point(110, 332);
            this.groupBoxToPay.Name = "groupBoxToPay";
            this.groupBoxToPay.Size = new System.Drawing.Size(302, 151);
            this.groupBoxToPay.TabIndex = 1;
            this.groupBoxToPay.TabStop = false;
            this.groupBoxToPay.Text = "Sum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "hrn";
            // 
            // lbToPay
            // 
            this.lbToPay.AutoSize = true;
            this.lbToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbToPay.Location = new System.Drawing.Point(159, 70);
            this.lbToPay.Name = "lbToPay";
            this.lbToPay.Size = new System.Drawing.Size(87, 31);
            this.lbToPay.TabIndex = 12;
            this.lbToPay.Text = "00,00";
            this.lbToPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btToPay
            // 
            this.btToPay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btToPay.Location = new System.Drawing.Point(48, 50);
            this.btToPay.Name = "btToPay";
            this.btToPay.Size = new System.Drawing.Size(84, 51);
            this.btToPay.TabIndex = 0;
            this.btToPay.Text = "Sum ";
            this.btToPay.UseVisualStyleBackColor = false;
            this.btToPay.Click += new System.EventHandler(this.btToPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 495);
            this.Controls.Add(this.groupBoxToPay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSumOil.ResumeLayout(false);
            this.groupBoxSumOil.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSumShop.ResumeLayout(false);
            this.groupBoxSumShop.PerformLayout();
            this.groupBoxToPay.ResumeLayout(false);
            this.groupBoxToPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbOil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxToPay;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.GroupBox groupBoxSumOil;
        private System.Windows.Forms.Label lbSumOil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuantityOil;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.ComboBox comboBoxOil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.GroupBox groupBoxSumShop;
        private System.Windows.Forms.Label lbSumShop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPriceHamb;
        private System.Windows.Forms.Label lbChips;
        private System.Windows.Forms.Label lbCola;
        private System.Windows.Forms.Label lbHotdog;
        private System.Windows.Forms.TextBox tbQuantCola;
        private System.Windows.Forms.TextBox tbPriceCola;
        private System.Windows.Forms.TextBox tbQuantChips;
        private System.Windows.Forms.TextBox tbPriceChips;
        private System.Windows.Forms.TextBox tbQuantHotDog;
        private System.Windows.Forms.TextBox tbPriceHotDog;
        private System.Windows.Forms.TextBox tbQuantHamb;
        private System.Windows.Forms.Label lbHamburg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbToPay;
        private System.Windows.Forms.Button btToPay;
        private System.Windows.Forms.BindingSource oilBindingSource;
        private System.Windows.Forms.BindingSource oilBindingSource1;
    }
}

