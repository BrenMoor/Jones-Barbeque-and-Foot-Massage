namespace Jones_Barbeque_and_Foot_Massage
{
    partial class Form1
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textboxBurger = new System.Windows.Forms.TextBox();
            this.textboxHotdog = new System.Windows.Forms.TextBox();
            this.textboxFootMassage = new System.Windows.Forms.TextBox();
            this.labelBurgers = new System.Windows.Forms.Label();
            this.labelHotdogs = new System.Windows.Forms.Label();
            this.labelFootMassage = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelSubtotalNumbers = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTaxNumbers = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalNumbers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTendered = new System.Windows.Forms.Label();
            this.textboxTendered = new System.Windows.Forms.TextBox();
            this.buttonCalculateChange = new System.Windows.Forms.Button();
            this.labelChange = new System.Windows.Forms.Label();
            this.buttonPrintReciept = new System.Windows.Forms.Button();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.labelCatch = new System.Windows.Forms.Label();
            this.labelChangeNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 204);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(271, 40);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate Totals";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textboxBurger
            // 
            this.textboxBurger.Location = new System.Drawing.Point(216, 70);
            this.textboxBurger.Name = "textboxBurger";
            this.textboxBurger.Size = new System.Drawing.Size(67, 26);
            this.textboxBurger.TabIndex = 1;
            // 
            // textboxHotdog
            // 
            this.textboxHotdog.Location = new System.Drawing.Point(216, 113);
            this.textboxHotdog.Name = "textboxHotdog";
            this.textboxHotdog.Size = new System.Drawing.Size(67, 26);
            this.textboxHotdog.TabIndex = 2;
            // 
            // textboxFootMassage
            // 
            this.textboxFootMassage.Location = new System.Drawing.Point(216, 160);
            this.textboxFootMassage.Name = "textboxFootMassage";
            this.textboxFootMassage.Size = new System.Drawing.Size(67, 26);
            this.textboxFootMassage.TabIndex = 3;
            // 
            // labelBurgers
            // 
            this.labelBurgers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelBurgers.Location = new System.Drawing.Point(12, 70);
            this.labelBurgers.Name = "labelBurgers";
            this.labelBurgers.Size = new System.Drawing.Size(184, 26);
            this.labelBurgers.TabIndex = 4;
            this.labelBurgers.Text = "Number of Burgers";
            // 
            // labelHotdogs
            // 
            this.labelHotdogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelHotdogs.Location = new System.Drawing.Point(12, 113);
            this.labelHotdogs.Name = "labelHotdogs";
            this.labelHotdogs.Size = new System.Drawing.Size(184, 26);
            this.labelHotdogs.TabIndex = 5;
            this.labelHotdogs.Text = "Number of Hotdogs";
            // 
            // labelFootMassage
            // 
            this.labelFootMassage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelFootMassage.Location = new System.Drawing.Point(12, 160);
            this.labelFootMassage.Name = "labelFootMassage";
            this.labelFootMassage.Size = new System.Drawing.Size(198, 26);
            this.labelFootMassage.TabIndex = 6;
            this.labelFootMassage.Text = "Number of Foot Massages";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSubtotal.Location = new System.Drawing.Point(12, 280);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(69, 20);
            this.labelSubtotal.TabIndex = 7;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // labelSubtotalNumbers
            // 
            this.labelSubtotalNumbers.AutoSize = true;
            this.labelSubtotalNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSubtotalNumbers.Location = new System.Drawing.Point(232, 280);
            this.labelSubtotalNumbers.Name = "labelSubtotalNumbers";
            this.labelSubtotalNumbers.Size = new System.Drawing.Size(40, 20);
            this.labelSubtotalNumbers.TabIndex = 8;
            this.labelSubtotalNumbers.Text = "0.00";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTax.Location = new System.Drawing.Point(12, 313);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(34, 20);
            this.labelTax.TabIndex = 9;
            this.labelTax.Text = "Tax";
            // 
            // labelTaxNumbers
            // 
            this.labelTaxNumbers.AutoSize = true;
            this.labelTaxNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTaxNumbers.Location = new System.Drawing.Point(232, 313);
            this.labelTaxNumbers.Name = "labelTaxNumbers";
            this.labelTaxNumbers.Size = new System.Drawing.Size(40, 20);
            this.labelTaxNumbers.TabIndex = 10;
            this.labelTaxNumbers.Text = "0.00";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTotal.Location = new System.Drawing.Point(12, 347);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 20);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total";
            // 
            // labelTotalNumbers
            // 
            this.labelTotalNumbers.AutoSize = true;
            this.labelTotalNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTotalNumbers.Location = new System.Drawing.Point(232, 347);
            this.labelTotalNumbers.Name = "labelTotalNumbers";
            this.labelTotalNumbers.Size = new System.Drawing.Size(40, 20);
            this.labelTotalNumbers.TabIndex = 12;
            this.labelTotalNumbers.Text = "0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 17);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(303, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 742);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox3.Location = new System.Drawing.Point(-10, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(681, 70);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Yellow;
            this.labelTitle.Font = new System.Drawing.Font("Naughty Squirrel Demo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(-10, -6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(646, 70);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "JONE\'S BBQ AND FOOT MASSAGE";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTendered
            // 
            this.labelTendered.AutoSize = true;
            this.labelTendered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTendered.Location = new System.Drawing.Point(12, 449);
            this.labelTendered.Name = "labelTendered";
            this.labelTendered.Size = new System.Drawing.Size(77, 20);
            this.labelTendered.TabIndex = 17;
            this.labelTendered.Text = "Tendered";
            // 
            // textboxTendered
            // 
            this.textboxTendered.Location = new System.Drawing.Point(95, 446);
            this.textboxTendered.Name = "textboxTendered";
            this.textboxTendered.Size = new System.Drawing.Size(188, 26);
            this.textboxTendered.TabIndex = 18;
            // 
            // buttonCalculateChange
            // 
            this.buttonCalculateChange.Location = new System.Drawing.Point(12, 500);
            this.buttonCalculateChange.Name = "buttonCalculateChange";
            this.buttonCalculateChange.Size = new System.Drawing.Size(271, 37);
            this.buttonCalculateChange.TabIndex = 19;
            this.buttonCalculateChange.Text = "Calculate Change";
            this.buttonCalculateChange.UseVisualStyleBackColor = true;
            this.buttonCalculateChange.Click += new System.EventHandler(this.buttonCalculateChange_Click);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelChange.Location = new System.Drawing.Point(12, 558);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(65, 20);
            this.labelChange.TabIndex = 20;
            this.labelChange.Text = "Change";
            // 
            // buttonPrintReciept
            // 
            this.buttonPrintReciept.Location = new System.Drawing.Point(16, 602);
            this.buttonPrintReciept.Name = "buttonPrintReciept";
            this.buttonPrintReciept.Size = new System.Drawing.Size(267, 35);
            this.buttonPrintReciept.TabIndex = 22;
            this.buttonPrintReciept.Text = "Print Reciept";
            this.buttonPrintReciept.UseVisualStyleBackColor = true;
            this.buttonPrintReciept.Click += new System.EventHandler(this.buttonPrintReciept_Click);
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Location = new System.Drawing.Point(324, 602);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(295, 35);
            this.buttonNewOrder.TabIndex = 23;
            this.buttonNewOrder.Text = "New Order";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // labelCatch
            // 
            this.labelCatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatch.Location = new System.Drawing.Point(324, 86);
            this.labelCatch.Name = "labelCatch";
            this.labelCatch.Size = new System.Drawing.Size(295, 100);
            this.labelCatch.TabIndex = 24;
            this.labelCatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChangeNumber
            // 
            this.labelChangeNumber.AutoSize = true;
            this.labelChangeNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelChangeNumber.Location = new System.Drawing.Point(232, 558);
            this.labelChangeNumber.Name = "labelChangeNumber";
            this.labelChangeNumber.Size = new System.Drawing.Size(40, 20);
            this.labelChangeNumber.TabIndex = 25;
            this.labelChangeNumber.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(631, 651);
            this.Controls.Add(this.labelChangeNumber);
            this.Controls.Add(this.labelCatch);
            this.Controls.Add(this.buttonNewOrder);
            this.Controls.Add(this.buttonPrintReciept);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.buttonCalculateChange);
            this.Controls.Add(this.textboxTendered);
            this.Controls.Add(this.labelTendered);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTotalNumbers);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTaxNumbers);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotalNumbers);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.labelFootMassage);
            this.Controls.Add(this.labelHotdogs);
            this.Controls.Add(this.labelBurgers);
            this.Controls.Add(this.textboxFootMassage);
            this.Controls.Add(this.textboxHotdog);
            this.Controls.Add(this.textboxBurger);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "Jones Barbeque and Foot Massage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textboxBurger;
        private System.Windows.Forms.TextBox textboxHotdog;
        private System.Windows.Forms.TextBox textboxFootMassage;
        private System.Windows.Forms.Label labelBurgers;
        private System.Windows.Forms.Label labelHotdogs;
        private System.Windows.Forms.Label labelFootMassage;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelSubtotalNumbers;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTaxNumbers;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalNumbers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTendered;
        private System.Windows.Forms.TextBox textboxTendered;
        private System.Windows.Forms.Button buttonCalculateChange;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textboxChange;
        private System.Windows.Forms.Button buttonPrintReciept;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.Label labelCatch;
        private System.Windows.Forms.Label labelChangeNumber;
    }
}

