namespace kleine_Finanzsoftware
{
    partial class FormPref
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPref));
            this.create_new_bt = new System.Windows.Forms.RadioButton();
            this.load_data_bt = new System.Windows.Forms.RadioButton();
            this.ok_button = new System.Windows.Forms.Button();
            this.new_search = new System.Windows.Forms.Button();
            this.load_search = new System.Windows.Forms.Button();
            this.new_field = new System.Windows.Forms.TextBox();
            this.load_field = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create_new_bt
            // 
            this.create_new_bt.AutoSize = true;
            this.create_new_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_new_bt.ForeColor = System.Drawing.Color.White;
            this.create_new_bt.Location = new System.Drawing.Point(48, 47);
            this.create_new_bt.Name = "create_new_bt";
            this.create_new_bt.Size = new System.Drawing.Size(198, 28);
            this.create_new_bt.TabIndex = 0;
            this.create_new_bt.TabStop = true;
            this.create_new_bt.Text = "Neue Datei erstellen";
            this.create_new_bt.UseVisualStyleBackColor = true;
            this.create_new_bt.CheckedChanged += new System.EventHandler(this.create_new_bt_CheckedChanged);
            // 
            // load_data_bt
            // 
            this.load_data_bt.AutoSize = true;
            this.load_data_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_data_bt.ForeColor = System.Drawing.Color.White;
            this.load_data_bt.Location = new System.Drawing.Point(48, 178);
            this.load_data_bt.Name = "load_data_bt";
            this.load_data_bt.Size = new System.Drawing.Size(128, 28);
            this.load_data_bt.TabIndex = 1;
            this.load_data_bt.TabStop = true;
            this.load_data_bt.Text = "Datei Laden";
            this.load_data_bt.UseVisualStyleBackColor = true;
            this.load_data_bt.CheckedChanged += new System.EventHandler(this.load_data_bt_CheckedChanged);
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(617, 281);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(112, 60);
            this.ok_button.TabIndex = 17;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // new_search
            // 
            this.new_search.BackColor = System.Drawing.Color.SteelBlue;
            this.new_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_search.Location = new System.Drawing.Point(301, 44);
            this.new_search.Name = "new_search";
            this.new_search.Size = new System.Drawing.Size(120, 39);
            this.new_search.TabIndex = 19;
            this.new_search.Text = "Durchsuchen";
            this.new_search.UseVisualStyleBackColor = false;
            this.new_search.Click += new System.EventHandler(this.new_search_Click);
            // 
            // load_search
            // 
            this.load_search.BackColor = System.Drawing.Color.SteelBlue;
            this.load_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_search.Location = new System.Drawing.Point(301, 178);
            this.load_search.Name = "load_search";
            this.load_search.Size = new System.Drawing.Size(120, 39);
            this.load_search.TabIndex = 20;
            this.load_search.Text = "Durchsuchen";
            this.load_search.UseVisualStyleBackColor = false;
            this.load_search.Click += new System.EventHandler(this.load_search_Click);
            // 
            // new_field
            // 
            this.new_field.BackColor = System.Drawing.Color.Silver;
            this.new_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_field.Location = new System.Drawing.Point(48, 89);
            this.new_field.Name = "new_field";
            this.new_field.ReadOnly = true;
            this.new_field.Size = new System.Drawing.Size(681, 26);
            this.new_field.TabIndex = 21;
            // 
            // load_field
            // 
            this.load_field.BackColor = System.Drawing.Color.Silver;
            this.load_field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.load_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_field.Location = new System.Drawing.Point(48, 223);
            this.load_field.Name = "load_field";
            this.load_field.ReadOnly = true;
            this.load_field.Size = new System.Drawing.Size(681, 26);
            this.load_field.TabIndex = 22;
            // 
            // FormPref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(770, 362);
            this.Controls.Add(this.load_field);
            this.Controls.Add(this.new_field);
            this.Controls.Add(this.load_search);
            this.Controls.Add(this.new_search);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.load_data_bt);
            this.Controls.Add(this.create_new_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPref";
            this.ShowIcon = false;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPref_FormClosing);
            this.Load += new System.EventHandler(this.FormPref_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton create_new_bt;
        private System.Windows.Forms.RadioButton load_data_bt;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button new_search;
        private System.Windows.Forms.Button load_search;
        private System.Windows.Forms.TextBox new_field;
        private System.Windows.Forms.TextBox load_field;
    }
}