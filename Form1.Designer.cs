namespace Pizza_Project
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSizeLarge = new System.Windows.Forms.RadioButton();
            this.rbSizeSmall = new System.Windows.Forms.RadioButton();
            this.rbSizeMedium = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.gbCrusyType = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrusyType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbSizeLarge);
            this.gbSize.Controls.Add(this.rbSizeSmall);
            this.gbSize.Controls.Add(this.rbSizeMedium);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(27, 33);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 211);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbSizeLarge
            // 
            this.rbSizeLarge.AutoSize = true;
            this.rbSizeLarge.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSizeLarge.Location = new System.Drawing.Point(24, 123);
            this.rbSizeLarge.Name = "rbSizeLarge";
            this.rbSizeLarge.Size = new System.Drawing.Size(60, 20);
            this.rbSizeLarge.TabIndex = 2;
            this.rbSizeLarge.TabStop = true;
            this.rbSizeLarge.Tag = "40";
            this.rbSizeLarge.Text = "Large";
            this.rbSizeLarge.UseVisualStyleBackColor = true;
            this.rbSizeLarge.CheckedChanged += new System.EventHandler(this.rbSizeLarge_CheckedChanged);
            // 
            // rbSizeSmall
            // 
            this.rbSizeSmall.AutoSize = true;
            this.rbSizeSmall.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSizeSmall.Location = new System.Drawing.Point(24, 37);
            this.rbSizeSmall.Name = "rbSizeSmall";
            this.rbSizeSmall.Size = new System.Drawing.Size(60, 20);
            this.rbSizeSmall.TabIndex = 0;
            this.rbSizeSmall.TabStop = true;
            this.rbSizeSmall.Tag = "20";
            this.rbSizeSmall.Text = "Small";
            this.rbSizeSmall.UseVisualStyleBackColor = true;
            this.rbSizeSmall.CheckedChanged += new System.EventHandler(this.rbSizeSmall_CheckedChanged);
            // 
            // rbSizeMedium
            // 
            this.rbSizeMedium.AutoSize = true;
            this.rbSizeMedium.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSizeMedium.Location = new System.Drawing.Point(24, 80);
            this.rbSizeMedium.Name = "rbSizeMedium";
            this.rbSizeMedium.Size = new System.Drawing.Size(73, 20);
            this.rbSizeMedium.TabIndex = 1;
            this.rbSizeMedium.TabStop = true;
            this.rbSizeMedium.Tag = "35";
            this.rbSizeMedium.Text = "Medium";
            this.rbSizeMedium.UseVisualStyleBackColor = true;
            this.rbSizeMedium.CheckedChanged += new System.EventHandler(this.rbSizeMedium_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(275, 33);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(200, 211);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chkMushrooms.Location = new System.Drawing.Point(6, 124);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(101, 21);
            this.chkMushrooms.TabIndex = 6;
            this.chkMushrooms.Tag = "4";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(6, 38);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(104, 20);
            this.chkExtraCheese.TabIndex = 4;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chkOlives.Location = new System.Drawing.Point(6, 79);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(65, 21);
            this.chkOlives.TabIndex = 5;
            this.chkOlives.Tag = "3";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // gbCrusyType
            // 
            this.gbCrusyType.Controls.Add(this.rbThick);
            this.gbCrusyType.Controls.Add(this.rbThin);
            this.gbCrusyType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrusyType.Location = new System.Drawing.Point(27, 250);
            this.gbCrusyType.Name = "gbCrusyType";
            this.gbCrusyType.Size = new System.Drawing.Size(200, 100);
            this.gbCrusyType.TabIndex = 2;
            this.gbCrusyType.TabStop = false;
            this.gbCrusyType.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Tahoma", 8F);
            this.rbThick.Location = new System.Drawing.Point(6, 69);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(61, 21);
            this.rbThick.TabIndex = 4;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "4";
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Font = new System.Drawing.Font("Tahoma", 8F);
            this.rbThin.Location = new System.Drawing.Point(0, 35);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(55, 21);
            this.rbThin.TabIndex = 3;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(275, 250);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(200, 100);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where to Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Tahoma", 8F);
            this.rbTakeOut.Location = new System.Drawing.Point(71, 35);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(85, 21);
            this.rbTakeOut.TabIndex = 4;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Tag = "4";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.rbEatIn.Location = new System.Drawing.Point(0, 35);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(65, 21);
            this.rbEatIn.TabIndex = 3;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "0";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.label5);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.label1);
            this.gbOrderSummary.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbOrderSummary.Location = new System.Drawing.Point(565, 33);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(200, 317);
            this.gbOrderSummary.TabIndex = 4;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 30F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalPrice.Location = new System.Drawing.Point(57, 247);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(79, 60);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "$0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Price:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblWhereToEat.Location = new System.Drawing.Point(129, 183);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(44, 17);
            this.lblWhereToEat.TabIndex = 10;
            this.lblWhereToEat.Text = "Eat In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Where to Eat:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblCrustType.Location = new System.Drawing.Point(115, 145);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(71, 17);
            this.lblCrustType.TabIndex = 8;
            this.lblCrustType.Text = "Thin Crust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Crust Type:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblToppings.Location = new System.Drawing.Point(8, 110);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(85, 17);
            this.lblToppings.TabIndex = 6;
            this.lblToppings.Text = "No Toppings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toppings:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblSize.Location = new System.Drawing.Point(64, 41);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 17);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Medium";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(270, 448);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(115, 23);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 537);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrusyType);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrusyType.ResumeLayout(false);
            this.gbCrusyType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbSizeLarge;
        private System.Windows.Forms.RadioButton rbSizeSmall;
        private System.Windows.Forms.RadioButton rbSizeMedium;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbCrusyType;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOrderPizza;
    }
}

