using System.Windows.Forms;

namespace kleine_Finanzsoftware
{
    partial class FormFix
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFix));
            this.listView1 = new System.Windows.Forms.ListView();
            this.usage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.period = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.abgebucht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.einnahmen_ausgaben_bt = new System.Windows.Forms.Button();
            this.fix_bt = new System.Windows.Forms.Button();
            this.finance_box = new System.Windows.Forms.GroupBox();
            this.difference_label = new System.Windows.Forms.Label();
            this.spend_label = new System.Windows.Forms.Label();
            this.inc_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stats_button = new System.Windows.Forms.Button();
            this.pref_button = new System.Windows.Forms.Label();
            this.save_bt = new System.Windows.Forms.Label();
            this.finance_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usage,
            this.date,
            this.period,
            this.money,
            this.abgebucht});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 65);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 415);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // usage
            // 
            this.usage.Text = "Verwendungszweck";
            this.usage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date
            // 
            this.date.Text = "Datum";
            // 
            // period
            // 
            this.period.Text = "Periode";
            this.period.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // money
            // 
            this.money.Text = "Betrag";
            this.money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.money.Width = 260;
            // 
            // abgebucht
            // 
            this.abgebucht.Text = "Einnahme/Ausgabe";
            this.abgebucht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Tomato;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(169, 513);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(195, 94);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Eintrag löschen";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.PeachPuff;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(370, 513);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(195, 94);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "Eintrag bearbeiten";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(601, 513);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(195, 94);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "Eintrag hinzufügen";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.BackColor = System.Drawing.Color.DimGray;
            this.groupBoxButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxButtons.Location = new System.Drawing.Point(16, 459);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(147, 165);
            this.groupBoxButtons.TabIndex = 4;
            this.groupBoxButtons.TabStop = false;
            // 
            // einnahmen_ausgaben_bt
            // 
            this.einnahmen_ausgaben_bt.BackColor = System.Drawing.Color.SteelBlue;
            this.einnahmen_ausgaben_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.einnahmen_ausgaben_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.einnahmen_ausgaben_bt.Location = new System.Drawing.Point(37, 12);
            this.einnahmen_ausgaben_bt.Name = "einnahmen_ausgaben_bt";
            this.einnahmen_ausgaben_bt.Size = new System.Drawing.Size(202, 47);
            this.einnahmen_ausgaben_bt.TabIndex = 5;
            this.einnahmen_ausgaben_bt.Text = "Einnahmen/Ausgaben";
            this.einnahmen_ausgaben_bt.UseVisualStyleBackColor = false;
            this.einnahmen_ausgaben_bt.Click += new System.EventHandler(this.einnahmen_ausgaben_bt_Click);
            // 
            // fix_bt
            // 
            this.fix_bt.BackColor = System.Drawing.Color.Silver;
            this.fix_bt.Enabled = false;
            this.fix_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fix_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fix_bt.Location = new System.Drawing.Point(261, 12);
            this.fix_bt.Name = "fix_bt";
            this.fix_bt.Size = new System.Drawing.Size(201, 47);
            this.fix_bt.TabIndex = 6;
            this.fix_bt.Text = "Fixausgaben";
            this.fix_bt.UseVisualStyleBackColor = false;
            // 
            // finance_box
            // 
            this.finance_box.BackColor = System.Drawing.Color.Gainsboro;
            this.finance_box.Controls.Add(this.difference_label);
            this.finance_box.Controls.Add(this.spend_label);
            this.finance_box.Controls.Add(this.inc_label);
            this.finance_box.Controls.Add(this.label4);
            this.finance_box.Controls.Add(this.label2);
            this.finance_box.Controls.Add(this.label1);
            this.finance_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finance_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finance_box.Location = new System.Drawing.Point(820, 199);
            this.finance_box.Name = "finance_box";
            this.finance_box.Size = new System.Drawing.Size(359, 131);
            this.finance_box.TabIndex = 5;
            this.finance_box.TabStop = false;
            // 
            // difference_label
            // 
            this.difference_label.AutoSize = true;
            this.difference_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference_label.Location = new System.Drawing.Point(239, 86);
            this.difference_label.Name = "difference_label";
            this.difference_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.difference_label.Size = new System.Drawing.Size(36, 20);
            this.difference_label.TabIndex = 7;
            this.difference_label.Text = "122";
            // 
            // spend_label
            // 
            this.spend_label.AutoSize = true;
            this.spend_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spend_label.Location = new System.Drawing.Point(239, 47);
            this.spend_label.Name = "spend_label";
            this.spend_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spend_label.Size = new System.Drawing.Size(36, 20);
            this.spend_label.TabIndex = 5;
            this.spend_label.Text = "122";
            // 
            // inc_label
            // 
            this.inc_label.AutoSize = true;
            this.inc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inc_label.Location = new System.Drawing.Point(239, 6);
            this.inc_label.Name = "inc_label";
            this.inc_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inc_label.Size = new System.Drawing.Size(36, 20);
            this.inc_label.TabIndex = 4;
            this.inc_label.Text = "122";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Differenz diesen Monat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fixkosten diesen Monat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Einnahmen diesen Monat:";
            // 
            // stats_button
            // 
            this.stats_button.BackColor = System.Drawing.Color.SteelBlue;
            this.stats_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_button.Location = new System.Drawing.Point(497, 12);
            this.stats_button.Name = "stats_button";
            this.stats_button.Size = new System.Drawing.Size(201, 47);
            this.stats_button.TabIndex = 7;
            this.stats_button.Text = "Statistiken";
            this.stats_button.UseVisualStyleBackColor = false;
            this.stats_button.Click += new System.EventHandler(this.stats_button_Click);
            // 
            // pref_button
            // 
            this.pref_button.AutoSize = true;
            this.pref_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pref_button.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pref_button.ForeColor = System.Drawing.Color.White;
            this.pref_button.Location = new System.Drawing.Point(1032, 425);
            this.pref_button.Name = "pref_button";
            this.pref_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pref_button.Size = new System.Drawing.Size(63, 43);
            this.pref_button.TabIndex = 19;
            this.pref_button.Text = "⚙";
            this.pref_button.Click += new System.EventHandler(this.pref_button_Click);
            // 
            // save_bt
            // 
            this.save_bt.AutoSize = true;
            this.save_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_bt.Font = new System.Drawing.Font("Arial Unicode MS", 24F);
            this.save_bt.ForeColor = System.Drawing.Color.White;
            this.save_bt.Location = new System.Drawing.Point(951, 425);
            this.save_bt.Name = "save_bt";
            this.save_bt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save_bt.Size = new System.Drawing.Size(63, 43);
            this.save_bt.TabIndex = 18;
            this.save_bt.Text = "💾";
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // FormFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1218, 695);
            this.Controls.Add(this.pref_button);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.stats_button);
            this.Controls.Add(this.finance_box);
            this.Controls.Add(this.fix_bt);
            this.Controls.Add(this.einnahmen_ausgaben_bt);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFix";
            this.Text = "kleine Finanzsoftware";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFix_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.finance_box.ResumeLayout(false);
            this.finance_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader money;
        private System.Windows.Forms.ColumnHeader usage;
        private System.Windows.Forms.ColumnHeader abgebucht;
        private ColumnHeader date;
        private Button delete_button;
        private Button edit_button;
        private Button add_button;
        public GroupBox groupBoxButtons;
        private Button einnahmen_ausgaben_bt;
        private Button fix_bt;
        private GroupBox finance_box;
        private Label label2;
        private Label label1;
        private Label difference_label;
        private Label spend_label;
        private Label inc_label;
        private Label label4;
        private Button stats_button;
        private ColumnHeader period;
        private Label pref_button;
        private Label save_bt;
    }
}