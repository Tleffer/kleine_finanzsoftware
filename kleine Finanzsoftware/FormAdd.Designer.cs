namespace kleine_Finanzsoftware
{
    partial class FormAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.money_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usage_box = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.ausgabe_bt = new System.Windows.Forms.RadioButton();
            this.einnahme_bt = new System.Windows.Forms.RadioButton();
            this.abgebuchtGroup = new System.Windows.Forms.GroupBox();
            this.n_bt = new System.Windows.Forms.RadioButton();
            this.y_bt = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.periodBox = new System.Windows.Forms.ComboBox();
            this.abgebuchtGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Einnahme/Ausgabe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(811, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(478, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Betrag:";
            // 
            // money_box
            // 
            this.money_box.BackColor = System.Drawing.Color.LightGray;
            this.money_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.money_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_box.Location = new System.Drawing.Point(407, 76);
            this.money_box.Name = "money_box";
            this.money_box.Size = new System.Drawing.Size(213, 31);
            this.money_box.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Verwendungszweck:";
            // 
            // usage_box
            // 
            this.usage_box.BackColor = System.Drawing.Color.LightGray;
            this.usage_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usage_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usage_box.Location = new System.Drawing.Point(32, 76);
            this.usage_box.Name = "usage_box";
            this.usage_box.Size = new System.Drawing.Size(299, 31);
            this.usage_box.TabIndex = 17;
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Tomato;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(923, 337);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(140, 76);
            this.cancel_button.TabIndex = 16;
            this.cancel_button.Text = "Abbrechen";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(759, 337);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(132, 76);
            this.ok_button.TabIndex = 15;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // ausgabe_bt
            // 
            this.ausgabe_bt.AutoSize = true;
            this.ausgabe_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabe_bt.ForeColor = System.Drawing.Color.Black;
            this.ausgabe_bt.Location = new System.Drawing.Point(155, 22);
            this.ausgabe_bt.Name = "ausgabe_bt";
            this.ausgabe_bt.Size = new System.Drawing.Size(104, 28);
            this.ausgabe_bt.TabIndex = 11;
            this.ausgabe_bt.TabStop = true;
            this.ausgabe_bt.Text = "Ausgabe";
            this.ausgabe_bt.UseVisualStyleBackColor = true;
            this.ausgabe_bt.CheckedChanged += new System.EventHandler(this.einnahme_bt_CheckedChanged);
            // 
            // einnahme_bt
            // 
            this.einnahme_bt.AutoSize = true;
            this.einnahme_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.einnahme_bt.ForeColor = System.Drawing.Color.Black;
            this.einnahme_bt.Location = new System.Drawing.Point(16, 22);
            this.einnahme_bt.Name = "einnahme_bt";
            this.einnahme_bt.Size = new System.Drawing.Size(115, 28);
            this.einnahme_bt.TabIndex = 10;
            this.einnahme_bt.TabStop = true;
            this.einnahme_bt.Text = "Einnahme";
            this.einnahme_bt.UseVisualStyleBackColor = true;
            this.einnahme_bt.CheckedChanged += new System.EventHandler(this.einnahme_bt_CheckedChanged);
            // 
            // abgebuchtGroup
            // 
            this.abgebuchtGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.abgebuchtGroup.Controls.Add(this.n_bt);
            this.abgebuchtGroup.Controls.Add(this.y_bt);
            this.abgebuchtGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abgebuchtGroup.Location = new System.Drawing.Point(407, 279);
            this.abgebuchtGroup.Name = "abgebuchtGroup";
            this.abgebuchtGroup.Size = new System.Drawing.Size(213, 73);
            this.abgebuchtGroup.TabIndex = 24;
            this.abgebuchtGroup.TabStop = false;
            // 
            // n_bt
            // 
            this.n_bt.AutoSize = true;
            this.n_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_bt.ForeColor = System.Drawing.Color.Black;
            this.n_bt.Location = new System.Drawing.Point(127, 22);
            this.n_bt.Name = "n_bt";
            this.n_bt.Size = new System.Drawing.Size(68, 28);
            this.n_bt.TabIndex = 11;
            this.n_bt.TabStop = true;
            this.n_bt.Text = "Nein";
            this.n_bt.UseVisualStyleBackColor = true;
            // 
            // y_bt
            // 
            this.y_bt.AutoSize = true;
            this.y_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_bt.ForeColor = System.Drawing.Color.Black;
            this.y_bt.Location = new System.Drawing.Point(16, 22);
            this.y_bt.Name = "y_bt";
            this.y_bt.Size = new System.Drawing.Size(47, 28);
            this.y_bt.TabIndex = 10;
            this.y_bt.TabStop = true;
            this.y_bt.Text = "Ja";
            this.y_bt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(438, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Abgebucht:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.ausgabe_bt);
            this.groupBox1.Controls.Add(this.einnahme_bt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 73);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // picker
            // 
            this.picker.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.picker.Location = new System.Drawing.Point(719, 76);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(284, 31);
            this.picker.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(811, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Periode:";
            // 
            // periodBox
            // 
            this.periodBox.BackColor = System.Drawing.Color.LightGray;
            this.periodBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.periodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodBox.FormattingEnabled = true;
            this.periodBox.Items.AddRange(new object[] {
            "jährlich",
            "halbjährlich",
            "vierteljährlich",
            "monatlich",
            "zweiwöchentlich",
            "wöchentlich",
            "täglich"});
            this.periodBox.Location = new System.Drawing.Point(759, 279);
            this.periodBox.Name = "periodBox";
            this.periodBox.Size = new System.Drawing.Size(224, 32);
            this.periodBox.TabIndex = 27;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1095, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.periodBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.money_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usage_box);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.abgebuchtGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdd";
            this.ShowIcon = false;
            this.Text = "Add";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.abgebuchtGroup.ResumeLayout(false);
            this.abgebuchtGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox money_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usage_box;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.RadioButton ausgabe_bt;
        private System.Windows.Forms.RadioButton einnahme_bt;
        private System.Windows.Forms.GroupBox abgebuchtGroup;
        private System.Windows.Forms.RadioButton n_bt;
        private System.Windows.Forms.RadioButton y_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox periodBox;
    }
}