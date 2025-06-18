using System.Windows.Forms;

namespace kleine_Finanzsoftware
{
    partial class FormStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStats));
            this.listView1 = new System.Windows.Forms.ListView();
            this.usage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.show_button = new System.Windows.Forms.Button();
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
            this.from_date = new System.Windows.Forms.DateTimePicker();
            this.to_date = new System.Windows.Forms.DateTimePicker();
            this.from_label = new System.Windows.Forms.Label();
            this.to_label = new System.Windows.Forms.Label();
            this.einnahmen_label = new System.Windows.Forms.Label();
            this.fix_label = new System.Windows.Forms.Label();
            this.einnahmen_box = new System.Windows.Forms.CheckBox();
            this.ausgaben_box = new System.Windows.Forms.CheckBox();
            this.variabel_box = new System.Windows.Forms.CheckBox();
            this.fix_box = new System.Windows.Forms.CheckBox();
            this.save_bt = new System.Windows.Forms.Label();
            this.pref_button = new System.Windows.Forms.Label();
            this.finance_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usage,
            this.date,
            this.money});
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
            this.date.Text = "Datum/Periode";
            // 
            // money
            // 
            this.money.Text = "Betrag";
            this.money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.money.Width = 260;
            // 
            // show_button
            // 
            this.show_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.show_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_button.Location = new System.Drawing.Point(169, 513);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(195, 94);
            this.show_button.TabIndex = 1;
            this.show_button.Text = "Statistik Anzeigen";
            this.show_button.UseVisualStyleBackColor = false;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.BackColor = System.Drawing.Color.LightGray;
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
            this.fix_bt.BackColor = System.Drawing.Color.SteelBlue;
            this.fix_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fix_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fix_bt.Location = new System.Drawing.Point(261, 12);
            this.fix_bt.Name = "fix_bt";
            this.fix_bt.Size = new System.Drawing.Size(201, 47);
            this.fix_bt.TabIndex = 6;
            this.fix_bt.Text = "Fixausgaben";
            this.fix_bt.UseVisualStyleBackColor = false;
            this.fix_bt.Click += new System.EventHandler(this.fix_bt_Click);
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
            this.difference_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference_label.Location = new System.Drawing.Point(195, 89);
            this.difference_label.Name = "difference_label";
            this.difference_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.difference_label.Size = new System.Drawing.Size(19, 25);
            this.difference_label.TabIndex = 7;
            this.difference_label.Text = "-";
            // 
            // spend_label
            // 
            this.spend_label.AutoSize = true;
            this.spend_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spend_label.Location = new System.Drawing.Point(195, 54);
            this.spend_label.Name = "spend_label";
            this.spend_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spend_label.Size = new System.Drawing.Size(19, 25);
            this.spend_label.TabIndex = 5;
            this.spend_label.Text = "-";
            // 
            // inc_label
            // 
            this.inc_label.AutoSize = true;
            this.inc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inc_label.Location = new System.Drawing.Point(195, 19);
            this.inc_label.Name = "inc_label";
            this.inc_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inc_label.Size = new System.Drawing.Size(19, 25);
            this.inc_label.TabIndex = 4;
            this.inc_label.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Differenz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ausgaben:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Einnahmen:";
            // 
            // stats_button
            // 
            this.stats_button.BackColor = System.Drawing.Color.Silver;
            this.stats_button.Enabled = false;
            this.stats_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_button.Location = new System.Drawing.Point(497, 12);
            this.stats_button.Name = "stats_button";
            this.stats_button.Size = new System.Drawing.Size(201, 47);
            this.stats_button.TabIndex = 7;
            this.stats_button.Text = "Statistiken";
            this.stats_button.UseVisualStyleBackColor = false;
            // 
            // from_date
            // 
            this.from_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_date.Location = new System.Drawing.Point(875, 556);
            this.from_date.Name = "from_date";
            this.from_date.Size = new System.Drawing.Size(165, 31);
            this.from_date.TabIndex = 8;
            // 
            // to_date
            // 
            this.to_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to_date.Location = new System.Drawing.Point(875, 483);
            this.to_date.Name = "to_date";
            this.to_date.Size = new System.Drawing.Size(165, 31);
            this.to_date.TabIndex = 9;
            // 
            // from_label
            // 
            this.from_label.AutoSize = true;
            this.from_label.BackColor = System.Drawing.Color.LightGray;
            this.from_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_label.ForeColor = System.Drawing.Color.Black;
            this.from_label.Location = new System.Drawing.Point(881, 433);
            this.from_label.Name = "from_label";
            this.from_label.Size = new System.Drawing.Size(60, 25);
            this.from_label.TabIndex = 8;
            this.from_label.Text = "Von:";
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.BackColor = System.Drawing.Color.LightGray;
            this.to_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_label.ForeColor = System.Drawing.Color.Black;
            this.to_label.Location = new System.Drawing.Point(967, 433);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(52, 25);
            this.to_label.TabIndex = 10;
            this.to_label.Text = "Bis:";
            // 
            // einnahmen_label
            // 
            this.einnahmen_label.AutoSize = true;
            this.einnahmen_label.BackColor = System.Drawing.Color.LightGray;
            this.einnahmen_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.einnahmen_label.ForeColor = System.Drawing.Color.Black;
            this.einnahmen_label.Location = new System.Drawing.Point(761, 21);
            this.einnahmen_label.Name = "einnahmen_label";
            this.einnahmen_label.Size = new System.Drawing.Size(241, 25);
            this.einnahmen_label.TabIndex = 11;
            this.einnahmen_label.Text = "Einnahmen/Ausgaben";
            // 
            // fix_label
            // 
            this.fix_label.AutoSize = true;
            this.fix_label.BackColor = System.Drawing.Color.LightGray;
            this.fix_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fix_label.ForeColor = System.Drawing.Color.Black;
            this.fix_label.Location = new System.Drawing.Point(1108, 21);
            this.fix_label.Name = "fix_label";
            this.fix_label.Size = new System.Drawing.Size(44, 25);
            this.fix_label.TabIndex = 12;
            this.fix_label.Text = "Fix";
            // 
            // einnahmen_box
            // 
            this.einnahmen_box.AutoSize = true;
            this.einnahmen_box.BackColor = System.Drawing.Color.LightGray;
            this.einnahmen_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.einnahmen_box.Location = new System.Drawing.Point(766, 86);
            this.einnahmen_box.Name = "einnahmen_box";
            this.einnahmen_box.Size = new System.Drawing.Size(153, 33);
            this.einnahmen_box.TabIndex = 13;
            this.einnahmen_box.Text = "Einnahmen";
            this.einnahmen_box.UseVisualStyleBackColor = false;
            // 
            // ausgaben_box
            // 
            this.ausgaben_box.AutoSize = true;
            this.ausgaben_box.BackColor = System.Drawing.Color.LightGray;
            this.ausgaben_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgaben_box.Location = new System.Drawing.Point(923, 86);
            this.ausgaben_box.Name = "ausgaben_box";
            this.ausgaben_box.Size = new System.Drawing.Size(140, 33);
            this.ausgaben_box.TabIndex = 14;
            this.ausgaben_box.Text = "Ausgaben";
            this.ausgaben_box.UseVisualStyleBackColor = false;
            // 
            // variabel_box
            // 
            this.variabel_box.AutoSize = true;
            this.variabel_box.BackColor = System.Drawing.Color.LightGray;
            this.variabel_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variabel_box.Location = new System.Drawing.Point(972, 147);
            this.variabel_box.Name = "variabel_box";
            this.variabel_box.Size = new System.Drawing.Size(121, 33);
            this.variabel_box.TabIndex = 16;
            this.variabel_box.Text = "Variabel";
            this.variabel_box.UseVisualStyleBackColor = false;
            // 
            // fix_box
            // 
            this.fix_box.AutoSize = true;
            this.fix_box.BackColor = System.Drawing.Color.LightGray;
            this.fix_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fix_box.Location = new System.Drawing.Point(815, 147);
            this.fix_box.Name = "fix_box";
            this.fix_box.Size = new System.Drawing.Size(64, 33);
            this.fix_box.TabIndex = 15;
            this.fix_box.Text = "Fix";
            this.fix_box.UseVisualStyleBackColor = false;
            // 
            // save_bt
            // 
            this.save_bt.AutoSize = true;
            this.save_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_bt.Font = new System.Drawing.Font("Arial Unicode MS", 24F);
            this.save_bt.ForeColor = System.Drawing.Color.White;
            this.save_bt.Location = new System.Drawing.Point(616, 604);
            this.save_bt.Name = "save_bt";
            this.save_bt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save_bt.Size = new System.Drawing.Size(63, 43);
            this.save_bt.TabIndex = 8;
            this.save_bt.Text = "💾";
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // pref_button
            // 
            this.pref_button.AutoSize = true;
            this.pref_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pref_button.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pref_button.ForeColor = System.Drawing.Color.White;
            this.pref_button.Location = new System.Drawing.Point(697, 604);
            this.pref_button.Name = "pref_button";
            this.pref_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pref_button.Size = new System.Drawing.Size(63, 43);
            this.pref_button.TabIndex = 17;
            this.pref_button.Text = "⚙";
            this.pref_button.Click += new System.EventHandler(this.pref_button_Click);
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1218, 695);
            this.Controls.Add(this.pref_button);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.variabel_box);
            this.Controls.Add(this.fix_box);
            this.Controls.Add(this.ausgaben_box);
            this.Controls.Add(this.einnahmen_box);
            this.Controls.Add(this.fix_label);
            this.Controls.Add(this.einnahmen_label);
            this.Controls.Add(this.to_label);
            this.Controls.Add(this.from_label);
            this.Controls.Add(this.to_date);
            this.Controls.Add(this.from_date);
            this.Controls.Add(this.stats_button);
            this.Controls.Add(this.finance_box);
            this.Controls.Add(this.fix_bt);
            this.Controls.Add(this.einnahmen_ausgaben_bt);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStats";
            this.Text = "kleine Finanzsoftware";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStats_FormClosing);
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
        private ColumnHeader date;
        private Button show_button;
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
        private DateTimePicker from_date;
        private DateTimePicker to_date;
        private Label from_label;
        private Label to_label;
        private Label einnahmen_label;
        private Label fix_label;
        private CheckBox einnahmen_box;
        private CheckBox ausgaben_box;
        private CheckBox variabel_box;
        private CheckBox fix_box;
        private Label save_bt;
        private Label pref_button;
    }
}