using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kleine_Finanzsoftware
{
    public partial class FormAdd : Form
    {
        Daten data;
        Object form;
        bool fix;
        public FormAdd(Daten data, Object form, bool fix)
        {
            InitializeComponent();
            this.data = data;
            this.form = form;
            this.fix = fix;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {

            try
            {
                Convert.ToDouble(money_box.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Betrag ein.");
                return;
            }
            if(fix)
            {
                data.fixList.Add(new DataFixEntry { datum = picker.Value, einnahme = einnahme_bt.Checked, usage = usage_box.Text, money = Convert.ToDouble(money_box.Text) , period = periodBox.Text});
            } else
            {
                data.datenList.Add(new DataEntry { datum = picker.Value, einnahme = einnahme_bt.Checked, gebucht = y_bt.Checked, usage = usage_box.Text, money = Convert.ToDouble(money_box.Text) });

                data.datenList = data.datenList.OrderBy(entry => entry.datum).ToList();
            }


            try
            {
                Form1 form = (Form1)this.form;
                form.refresh_list();
            }
            catch (Exception ex) { }
            try
            {
                FormFix form = (FormFix)this.form;
                form.refresh_list();
            }
            catch (Exception ex) { }
            this.Close();

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void einnahme_bt_CheckedChanged(object sender, EventArgs e)
        {

            if (einnahme_bt.Checked)
            {
                y_bt.Enabled = false;
                n_bt.Enabled = false;
                abgebuchtGroup.BackColor = Color.DarkGray;
                y_bt.Checked = false;
                n_bt.Checked = false;
            }
            else
            {
                y_bt.Enabled = true;
                n_bt.Enabled = true;
                abgebuchtGroup.BackColor = Color.Gainsboro;
            }
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            picker.Format = DateTimePickerFormat.Custom;
            if (fix)
            {
                picker.CustomFormat = "dd/MM";
                Controls.Remove(label5);
                Controls.Remove(abgebuchtGroup);
            } else
            {
                picker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
                Controls.Remove(label6);
                Controls.Remove(periodBox);

            }
        }
    }
}
