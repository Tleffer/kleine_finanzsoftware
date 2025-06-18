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
    public partial class FormEdit : Form
    {
        int index;
        Daten data;
        Object form;
        bool fix;
        public FormEdit(int index, Daten data, Object form, bool fix)
        {
            InitializeComponent();
            this.index = index;
            this.data = data;
            this.form = form;
            this.fix = fix;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form = (Form1)this.form;
                form.edit_mode = false;
                form.listView1.BackColor = Color.LightGray;
                form.groupBoxButtons.BackColor = Color.DimGray;
            }
            catch (Exception ex) { }
            try
            {
                FormFix form = (FormFix)this.form;
                form.edit_mode = false;
                form.listView1.BackColor = Color.LightGray;
                form.groupBoxButtons.BackColor = Color.DimGray;
            }
            catch (Exception ex) { }
            this.Close();
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
            if (fix)
            {
                data.fixList[index].money = Convert.ToDouble(money_box.Text);
                data.fixList[index].einnahme = einnahme_bt.Checked;
                data.fixList[index].datum = picker.Value;
                data.fixList[index].usage = usage_box.Text;
                data.fixList[index].period = periodBox.Text;

                try
                {
                    Form1 form = (Form1)this.form;
                    form.edit_mode = false;
                    form.listView1.BackColor = Color.LightGray;
                    form.groupBoxButtons.BackColor = Color.DimGray;
                    form.refresh_list();
                }
                catch (Exception ex) { }
                try
                {
                    FormFix form = (FormFix)this.form;
                    form.refresh_list();
                    form.edit_mode = false;
                    form.listView1.BackColor = Color.LightGray;
                    form.groupBoxButtons.BackColor = Color.DimGray;
                }
                catch (Exception ex) { }
                this.Close();
            }
            else
            {
                if (data.datenList[index].fix)
                {
                    MessageBox.Show("Diese Buchung ist eine Fixbuchung und kann nicht bearbeitet werden.");
                }
                else
                {
                    if (!einnahme_bt.Checked)
                    {
                        data.datenList[index].gebucht = y_bt.Checked;
                    }
                    else
                    {
                        data.datenList[index].gebucht = false;
                    }

                    data.datenList[index].money = Convert.ToDouble(money_box.Text);
                    data.datenList[index].einnahme = einnahme_bt.Checked;
                    data.datenList[index].datum = picker.Value;
                    data.datenList[index].usage = usage_box.Text;

                    data.datenList = data.datenList.OrderBy(entry => entry.datum).ToList();
                }
                try
                {
                    Form1 form = (Form1)this.form;
                    form.edit_mode = false;
                    form.listView1.BackColor = Color.LightGray;
                    form.groupBoxButtons.BackColor = Color.DimGray;
                    form.refresh_list();
                }
                catch (Exception ex) { }
                try
                {
                    FormFix form = (FormFix)this.form;
                    form.refresh_list();
                    form.edit_mode = false;
                    form.listView1.BackColor = Color.LightGray;
                    form.groupBoxButtons.BackColor = Color.DimGray;
                }
                catch (Exception ex) { }
                this.Close();
            }
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            picker.Format = DateTimePickerFormat.Custom;
            if(fix)
            {
                picker.CustomFormat = "dd/MM";

            } else
            {
                picker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            }
                

            if(fix)
            {
                picker.Value = data.fixList[index].datum;
                usage_box.Text = data.fixList[index].usage;
                money_box.Text = data.fixList[index].money.ToString();
                periodBox.Text = data.fixList[index].period;

                if (data.fixList[index].einnahme)
                {
                    einnahme_bt.Checked = true;
                    ausgabe_bt.Checked = false;
                }
                else
                {
                    einnahme_bt.Checked = false;
                    ausgabe_bt.Checked = true;
                }
                Controls.Remove(abgebuchtGroup);
                Controls.Remove(label5);
            } else
            {
                Controls.Remove(periodBox);
                Controls.Remove(label6);
                picker.Value = data.datenList[index].datum;
                usage_box.Text = data.datenList[index].usage;
                money_box.Text = data.datenList[index].money.ToString();

                if (data.datenList[index].einnahme)
                {
                    einnahme_bt.Checked = true;
                    ausgabe_bt.Checked = false;
                }
                else
                {
                    einnahme_bt.Checked = false;
                    ausgabe_bt.Checked = true;
                    if (data.datenList[index].gebucht)
                    {
                        y_bt.Checked = true;
                        n_bt.Checked = false;
                    }
                    else
                    {
                        y_bt.Checked = false;
                        n_bt.Checked = true;
                    }
                }
            }
        }


        private void einnahme_bt_CheckedChanged(object sender, EventArgs e)
        {
            if(einnahme_bt.Checked)
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

        private void y_bt_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
