namespace CoffeeShop
{
    partial class CoffeeShop
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
            this.BtnEspresso = new System.Windows.Forms.Button();
            this.BtnCapuchino = new System.Windows.Forms.Button();
            this.BtnDecaffeinedCoffee = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnMilk = new System.Windows.Forms.Button();
            this.BtnSugar = new System.Windows.Forms.Button();
            this.BtnCinnamon = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Bulgarian = new System.Windows.Forms.Button();
            this.English = new System.Windows.Forms.Button();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.TotalBill = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnEspresso
            // 
            this.BtnEspresso.Location = new System.Drawing.Point(12, -1);
            this.BtnEspresso.Name = "BtnEspresso";
            this.BtnEspresso.Size = new System.Drawing.Size(97, 52);
            this.BtnEspresso.TabIndex = 3;
            this.BtnEspresso.Text = "Espresso";
            this.BtnEspresso.UseVisualStyleBackColor = true;
            this.BtnEspresso.Click += new System.EventHandler(this.ButtonEsspresso_Click);
            // 
            // BtnCapuchino
            // 
            this.BtnCapuchino.Location = new System.Drawing.Point(12, 59);
            this.BtnCapuchino.Name = "BtnCapuchino";
            this.BtnCapuchino.Size = new System.Drawing.Size(97, 46);
            this.BtnCapuchino.TabIndex = 4;
            this.BtnCapuchino.Text = "Cappuccino";
            this.BtnCapuchino.UseVisualStyleBackColor = true;
            this.BtnCapuchino.Click += new System.EventHandler(this.ButtonCappuchino_Click);
            // 
            // BtnDecaffeinedCoffee
            // 
            this.BtnDecaffeinedCoffee.Location = new System.Drawing.Point(12, 123);
            this.BtnDecaffeinedCoffee.Name = "BtnDecaffeinedCoffee";
            this.BtnDecaffeinedCoffee.Size = new System.Drawing.Size(97, 58);
            this.BtnDecaffeinedCoffee.TabIndex = 5;
            this.BtnDecaffeinedCoffee.Text = "Decaffeined Coffee";
            this.BtnDecaffeinedCoffee.UseVisualStyleBackColor = true;
            this.BtnDecaffeinedCoffee.Click += new System.EventHandler(this.ButtonDecaffeinedCoffee_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 201);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(217, 46);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Clear";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // BtnMilk
            // 
            this.BtnMilk.Location = new System.Drawing.Point(134, -1);
            this.BtnMilk.Name = "BtnMilk";
            this.BtnMilk.Size = new System.Drawing.Size(97, 52);
            this.BtnMilk.TabIndex = 12;
            this.BtnMilk.Text = "Milk";
            this.BtnMilk.UseVisualStyleBackColor = true;
            this.BtnMilk.Click += new System.EventHandler(this.ButtonProduct_Click);
            // 
            // BtnSugar
            // 
            this.BtnSugar.Location = new System.Drawing.Point(132, 123);
            this.BtnSugar.Name = "BtnSugar";
            this.BtnSugar.Size = new System.Drawing.Size(97, 58);
            this.BtnSugar.TabIndex = 13;
            this.BtnSugar.Text = "Sugar";
            this.BtnSugar.UseVisualStyleBackColor = true;
            this.BtnSugar.Click += new System.EventHandler(this.ButtonProduct_Click);
            // 
            // BtnCinnamon
            // 
            this.BtnCinnamon.Location = new System.Drawing.Point(132, 59);
            this.BtnCinnamon.Name = "BtnCinnamon";
            this.BtnCinnamon.Size = new System.Drawing.Size(97, 46);
            this.BtnCinnamon.TabIndex = 14;
            this.BtnCinnamon.Text = "Cinnamon";
            this.BtnCinnamon.UseVisualStyleBackColor = true;
            this.BtnCinnamon.Click += new System.EventHandler(this.ButtonProduct_Click);
            // 
            // Result
            // 
            this.Result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Result.Location = new System.Drawing.Point(498, 68);
            this.Result.MaximumSize = new System.Drawing.Size(200, 179);
            this.Result.MinimumSize = new System.Drawing.Size(200, 179);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result.Size = new System.Drawing.Size(200, 179);
            this.Result.TabIndex = 15;
            this.Result.Text = "Bill: ";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Result.Visible = false;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Bulgarian
            // 
            this.Bulgarian.Location = new System.Drawing.Point(12, 270);
            this.Bulgarian.Name = "Bulgarian";
            this.Bulgarian.Size = new System.Drawing.Size(115, 23);
            this.Bulgarian.TabIndex = 16;
            this.Bulgarian.Text = "Language: Bulgarian";
            this.Bulgarian.UseVisualStyleBackColor = true;
            this.Bulgarian.Click += new System.EventHandler(this.ButtonBulgarianLanguage_Click);
            // 
            // English
            // 
            this.English.Location = new System.Drawing.Point(134, 269);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(95, 23);
            this.English.TabIndex = 17;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            this.English.Click += new System.EventHandler(this.ButtonEnglishLanguage_Click);
            // 
            // BtnBuy
            // 
            this.BtnBuy.Location = new System.Drawing.Point(373, 253);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(75, 49);
            this.BtnBuy.TabIndex = 18;
            this.BtnBuy.Text = "Buy";
            this.BtnBuy.UseVisualStyleBackColor = true;
            this.BtnBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // TotalBill
            // 
            this.TotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalBill.Location = new System.Drawing.Point(248, 6);
            this.TotalBill.Multiline = true;
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(200, 45);
            this.TotalBill.TabIndex = 19;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(248, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 179);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 305);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TotalBill);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.English);
            this.Controls.Add(this.Bulgarian);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.BtnCinnamon);
            this.Controls.Add(this.BtnSugar);
            this.Controls.Add(this.BtnMilk);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDecaffeinedCoffee);
            this.Controls.Add(this.BtnCapuchino);
            this.Controls.Add(this.BtnEspresso);
            this.MaximizeBox = false;
            this.Name = "CoffeeShop";
            this.Text = "Coffee Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEspresso;
        private System.Windows.Forms.Button BtnCapuchino;
        private System.Windows.Forms.Button BtnDecaffeinedCoffee;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnMilk;
        private System.Windows.Forms.Button BtnSugar;
        private System.Windows.Forms.Button BtnCinnamon;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Bulgarian;
        private System.Windows.Forms.Button English;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.TextBox TotalBill;
        private System.Windows.Forms.ListView listView1;
    }
}

