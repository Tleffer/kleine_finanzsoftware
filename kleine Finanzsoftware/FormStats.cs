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
    public partial class FormStats : Form
    {
        public Daten data;
        public bool delete_mode = false;
        public bool edit_mode = false;

        double income;
        double expenses;
        FormFix fixForm;
        Form1 original_form;
        Save save;
        public FormStats(Daten daten, Form1 original_form, FormFix fixform, Save save)
        {
            InitializeComponent();
            this.data = daten;
            this.original_form = original_form;
            this.fixForm = fixform;
            this.save = save;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.Size = new System.Drawing.Size(1920, 1080);

            listView1.Size = new System.Drawing.Size(this.Width / 100 * 95, this.Height / 100 * 80);
            usage.Width = listView1.Width / 50 * 30;
            date.Width = listView1.Width / 50 * 8;
            date.DisplayIndex = 1;
            money.Width = listView1.Width / 200 * 46;


            groupBoxButtons.Location = new Point(Width / 100 * 2, Height / 100 * 87);
            groupBoxButtons.Size = new Size(Width / 100 * 70, Height / 100 * 13);

            show_button.Location = new Point(Width / 100 * 4, Height / 100 * 89);

            from_date.Location = new Point(Width / 100 * 20, Height / 100 * 93);
            to_date.Location = new Point(Width / 100 * 30, Height / 100 * 93);

            from_label.Location = new Point(Width / 100 * 23, Height / 100 * 89);
            to_label.Location = new Point(Width / 100 * 33, Height / 100 * 89);
            einnahmen_label.Location = new Point(Width / 100 * 43, Height / 100 * 89);
            fix_label.Location = new Point(Width / 100 * 63, Height / 100 * 89);

            einnahmen_box.Location = new Point(Width / 100 * 42, Height / 100 * 93);
            ausgaben_box.Location = new Point(Width / 100 * 50, Height / 100 * 93);
            fix_box.Location = new Point(Width / 100 * 60, Height / 100 * 93);
            variabel_box.Location = new Point(Width / 100 * 65, Height / 100 * 93);


            einnahmen_ausgaben_bt.Location = new Point(Width / 100 * 3, Height / 100 * 1);
            fix_bt.Location = new Point(Width / 100 * 15, Height / 100 * 1);
            stats_button.Location = new Point(Width / 100 * 27, Height / 100 * 1);

            save_bt.Location = new Point(Width / 100 * 94, Height / 100 * 1);
            pref_button.Location = new Point(Width / 100 * 98, Height / 100 * 1);

            finance_box.Location = new Point(Width / 100 * 78, Height / 100 * 87);

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int selected_index = listView1.SelectedIndices[0];
            int list_index = data.datenList.Count - selected_index - 1;

        }

        public void refresh_list()
        {
            data.datenList = data.datenList.OrderBy(entry => entry.datum).ToList();
            listView1.Items.Clear();

            income = 0;
            expenses = 0;

            for (int i = 0; i < data.datenList.Count; i++)
            {
                //MessageBox.Show("" + i);

                if (data.datenList[i].datum >= from_date.Value && data.datenList[i].datum <= to_date.Value)
                {
                    if (((data.datenList[i].einnahme && einnahmen_box.Checked)
                    || (!(data.datenList[i].einnahme) && ausgaben_box.Checked))
                    && ((data.datenList[i].fix && fix_box.Checked)
                    || ((!data.datenList[i].fix) && variabel_box.Checked)))
                    {
                        String[] entry = new string[3];
                        if (data.datenList[i].fix)
                        {
                            entry[0] = data.datenList[i].usage + ", davon";

                        } else
                        {
                            entry[0] = data.datenList[i].usage;
                        }
                            

                        entry[1] = data.datenList[i].datum.ToString();
                        if (data.datenList[i].einnahme)
                        {
                            entry[2] = "" + data.datenList[i].money.ToString() + " €";
                        }
                        else
                        {
                            entry[2] = "-" + data.datenList[i].money.ToString() + " €";
                        }
                        ListViewItem item = new ListViewItem(entry);
                        if (data.datenList[i].einnahme)
                        {
                            item.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            item.BackColor = Color.LightCoral;
                        }
                        listView1.Items.Add(item);

                        if(data.datenList[i].fix)
                        {
                            for (int j = 0; j < data.fixListHistory.Count; j++)
                            {
                                if (data.fixListHistory[j].datum >= from_date.Value && data.fixListHistory[j].datum <= to_date.Value)
                                {
                                    if (((data.fixListHistory[j].einnahme && einnahmen_box.Checked)
                                    || (!(data.fixListHistory[j].einnahme) && ausgaben_box.Checked))
                                    && (data.fixListHistory[j].einnahme == data.datenList[i].einnahme)
                                    && (data.fixListHistory[j].datum == data.datenList[i].datum))
                                    {
                                        String[] entry2 = new string[3];
                                        entry2[0] = data.fixListHistory[j].usage;
                                        entry2[1] = data.fixListHistory[j].period;
                                        if (data.fixListHistory[j].einnahme)
                                        {
                                            entry2[2] = "" + data.fixListHistory[j].money.ToString() + " €";
                                        }
                                        else
                                        {
                                            entry2[2] = "-" + data.fixListHistory[j].money.ToString() + " €";
                                        }

                                        ListViewItem item2 = new ListViewItem(entry2);
                                        item2.BackColor = Color.Yellow; 
                                        listView1.Items.Add(item2);
                                    }
                                }
                            }
                            
                        }

                        if (data.datenList[i].einnahme)
                        {
                            income += data.datenList[i].money;
                        }
                        else
                        {
                            expenses += data.datenList[i].money;
                        }
                    }
                }
            }


            inc_label.Text = "" + income + " €";
            spend_label.Text = "" + expenses + " €";
            difference_label.Text = "" + (income - expenses) + " €";
            if (income == 0)
            {
                inc_label.Text = "-";
            }
            if (expenses == 0)
            {
                spend_label.Text = "-";
            }

        }


        private void fix_bt_Click(object sender, EventArgs e)
        {
            fixForm.Show();
            this.Hide();
        }

        public bool IsInCurrentMonth(DateTime date)
        {
            DateTime now = DateTime.Now;
            return date.Month == now.Month && date.Year == now.Year;
        }

        private void einnahmen_ausgaben_bt_Click(object sender, EventArgs e)
        {
            original_form.Show();
            this.Hide();
        }

        private void FormStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            save.SaveData(data);
            original_form.Close();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            from_date.Value = new DateTime(from_date.Value.Year, from_date.Value.Month, from_date.Value.Day, 0, 0, 0);
            to_date.Value = new DateTime(to_date.Value.Year, to_date.Value.Month, to_date.Value.Day, 23, 59, 59);
            refresh_list();
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            save.SaveData(data);
        }

        private void pref_button_Click(object sender, EventArgs e)
        {
            original_form.Show();
            original_form.pref_button_Click(sender, e);
            this.Hide();
        }
    }
}
