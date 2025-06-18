using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kleine_Finanzsoftware
{
    public partial class FormFix : Form
    {
        public Daten data;
        Form1 original_form;
        FormStats stas_form;
        Save save;
        public bool delete_mode = false;
        public bool edit_mode = false;

        List<DataFixEntry> historyEntries = new List<DataFixEntry>();

        double income;
        double expenses;
        public FormFix(Daten data, Form1 original_form, FormStats stas_form, Save save)
        {
            InitializeComponent();
            this.data = data;
            this.original_form = original_form;
            this.stas_form = stas_form;
            this.save = save;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stas_form = original_form.statsForm;
            this.WindowState = FormWindowState.Maximized;
            //this.Size = new System.Drawing.Size(1920, 1080);

            listView1.Size = new System.Drawing.Size(this.Width / 100 * 95, this.Height / 100 * 80);
            usage.Width = listView1.Width / 50 * 20;
            date.Width = listView1.Width / 50 * 6;
            date.DisplayIndex = 1;
            period.DisplayIndex = 2;
            money.Width = listView1.Width / 50 * 12;
            abgebucht.Width = listView1.Width / 200 * 22;
            period.Width = listView1.Width / 50 * 6;


            groupBoxButtons.Location = new Point(Width / 100 * 2, Height / 100 * 87);
            groupBoxButtons.Size = new Size(Width / 100 * 46, Height / 100 * 13);

            delete_button.Location = new Point(Width / 100 * 4, Height / 100 * 89);
            edit_button.Location = new Point(Width / 100 * 20, Height / 100 * 89);
            add_button.Location = new Point(Width / 100 * 36, Height / 100 * 89);

            einnahmen_ausgaben_bt.Location = new Point(Width / 100 * 3, Height / 100 * 1);
            fix_bt.Location = new Point(Width / 100 * 15, Height / 100 * 1);
            stats_button.Location = new Point(Width / 100 * 27, Height / 100 * 1);

            save_bt.Location = new Point(Width / 100 * 94, Height / 100 * 1);
            pref_button.Location = new Point(Width / 100 * 98, Height / 100 * 1);

            finance_box.Location = new Point(Width / 100 * 78, Height / 100 * 87);

            //data.fixList.Add(new DataFixEntry { money = 1000, usage = "ashjgdzusdaz", datum = DateTime.Now , period = "jährlich", einnahme = true});
            //data.fixList.Add(new DataFixEntry { money = 2000, usage = "ashjgdzusdaz", datum = DateTime.Now , period = "täglich", einnahme = false});

            refresh_list();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int selected_index = listView1.SelectedIndices[0];
            int list_index = data.fixList.Count - selected_index - 1;
            if (delete_mode)
            {
                FormDelete delf = new FormDelete(list_index, data, this, true);
                delf.Show();
            }
            else if (edit_mode)
            {
                FormEdit editForm = new FormEdit(list_index, data, this, true);
                editForm.Show();
            }


        }

        public void refresh_list()
        {
            listView1.Items.Clear();

            for (int i = data.fixList.Count - 1; i >= 0; i--)
            {
                //MessageBox.Show("" + i);
                String[] entry = new string[5];
                entry[0] = data.fixList[i].usage;

                if (data.fixList[i].period == "jährlich")
                {
                    entry[1] = "" + data.fixList[i].datum.Day + "." + data.fixList[i].datum.Month;
                } else if(data.fixList[i].period == "vierteljährlich")
                {
                    int day = data.fixList[i].datum.Day;
                    int[] month = new int[4];
                    month[0] = data.fixList[i].datum.Month;
                    month[1] = month[0] + 3;
                    month[2] = month[0] + 6;
                    month[3] = month[0] + 9;
                    for (int j = 0; j < 4; j++)
                    {
                        if (month[j] > 12)
                        {
                            month[j] -= 12;
                        }
                    }

                    entry[1] = "" + day + "." + month[1] + " & " + day + "." + month[2] + " & " + day + "." + month[2] + " & " + day + "." + month[3];
                }
                else if (data.fixList[i].period == "halbjährlich")
                {
                    entry[1] = "" + data.fixList[i].datum.Day + "." + data.fixList[i].datum.Month + " & " + data.fixList[i].datum.Day + "." + (data.fixList[i].datum.Month + (data.fixList[i].datum.Month <=6 ? 6 : -6));
                }
                else if (data.fixList[i].period == "wöchentlich")
                {
                    entry[1] = "" + data.fixList[i].datum.DayOfWeek;
                } else if (data.fixList[i].period == "monatlich")
                {
                    entry[1] = "" + data.fixList[i].datum.Day + ". des Monats";
                } else if (data.fixList[i].period == "täglich")
                {
                    entry[1] = "täglich";
                } else if (data.fixList[i].period == "zweiwöchentlich")
                {
                    entry[1] = "" + data.fixList[i].datum.Day + " & " + (data.fixList[i].datum.Day + (data.fixList[i].datum.Day <= 14 ? 14 : -14));
                }
                else
                {
                    entry[1] = "unbekannt";
                }

                entry[2] = data.fixList[i].period;

                if (data.fixList[i].einnahme)
                {
                    entry[3] = "" + data.fixList[i].money.ToString() + " €";
                }
                else
                {
                    entry[3] = "-" + data.fixList[i].money.ToString() + " €";
                }
                if (data.fixList[i].einnahme == true)
                {
                    entry[4] = "Einnahme";
                } else
                {
                    entry[4] = "Ausgabe";

                }
                ListViewItem item = new ListViewItem(entry);
                listView1.Items.Add(item);
            }
            calc_vals();
            add_to_bookings();
            add_to_history();

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            edit_mode = false;
            if (listView1.BackColor == Color.RosyBrown)
            {
                listView1.BackColor = Color.LightGray;
                groupBoxButtons.BackColor = Color.DimGray;
                delete_mode = false;
            }
            else
            {
                listView1.BackColor = Color.RosyBrown;
                groupBoxButtons.BackColor = Color.RosyBrown;
                delete_mode = true;
            }

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            delete_mode = false;
            if (listView1.BackColor == Color.PeachPuff)
            {
                listView1.BackColor = Color.LightGray;
                groupBoxButtons.BackColor = Color.DimGray;
                edit_mode = false;
            }
            else
            {
                listView1.BackColor = Color.PeachPuff;
                groupBoxButtons.BackColor = Color.SandyBrown;
                edit_mode = true;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            FormAdd addForm = new FormAdd(data, this, true);
            addForm.Show();
        }

        private bool IsInCurrentMonth(DateTime date)
        {
            DateTime now = DateTime.Now;
            return date.Month == now.Month;
        }

        private void stats_button_Click(object sender, EventArgs e)
        {
            save.SaveData(data);
            stas_form.Show();
            this.Hide();
        }

        private void einnahmen_ausgaben_bt_Click(object sender, EventArgs e)
        {
            original_form.Show();
            this.Hide();
        }

        private void FormFix_FormClosing(object sender, FormClosingEventArgs e)
        {
            save.SaveData(data);
            original_form.Close();
        }
        private void calc_vals()
        {
            historyEntries.Clear();
            DateTime now = DateTime.Now;
            income = 0;
            expenses = 0;
            for (int i = 0; i < data.fixList.Count; i++)
            {
                listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightGray; // Reset color for each item
                if (data.fixList[i].period == "täglich")
                {
                    if (data.fixList[i].einnahme)
                    {
                        income += (data.fixList[i].money * DateTime.DaysInMonth(now.Year, now.Month));
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightGreen;
                        historyEntries.Add(data.fixList[i]);
                    }
                    else
                    {
                        expenses += (data.fixList[i].money * DateTime.DaysInMonth(now.Year, now.Month));
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightCoral;
                        historyEntries.Add(data.fixList[i]);
                    }
                } else if(data.fixList[i].period == "wöchentlich")
                {
                    if (data.fixList[i].einnahme)
                    {
                        income += (data.fixList[i].money * WeeksInMonth());
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightGreen;
                        historyEntries.Add(data.fixList[i]);
                    }
                    else
                    {
                        expenses += (data.fixList[i].money * WeeksInMonth());
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightCoral;
                        historyEntries.Add(data.fixList[i]);
                    }
                }
                else if (data.fixList[i].period == "zweiwöchentlich")
                {
                    if (data.fixList[i].einnahme)
                    {
                        income += (data.fixList[i].money * 2);
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightGreen;
                        historyEntries.Add(data.fixList[i]);
                    }
                    else
                    {
                        expenses += (data.fixList[i].money * 2);
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightCoral;
                        historyEntries.Add(data.fixList[i]);
                    }
                }
                else if (data.fixList[i].period == "monatlich")
                {
                    if (data.fixList[i].einnahme)
                    {
                        income += (data.fixList[i].money);
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightGreen;
                        historyEntries.Add(data.fixList[i]);
                    }
                    else
                    {
                        expenses += (data.fixList[i].money);
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightCoral;
                        historyEntries.Add(data.fixList[i]);
                    }
                }
                else if (data.fixList[i].period == "vierteljährlich" && now.Month == data.fixList[i].datum.Month 
                || (now.Month == data.fixList[i].datum.Month + 3) 
                || (now.Month == data.fixList[i].datum.Month + 6) 
                || (now.Month == data.fixList[i].datum.Month + 9) 
                || (now.Month == data.fixList[i].datum.Month - 3) 
                || (now.Month == data.fixList[i].datum.Month - 6) 
                || (now.Month == data.fixList[i].datum.Month - 9))
                {
                    if (data.fixList[i].einnahme)
                    {
                        income += data.fixList[i].money;
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightGreen;
                        historyEntries.Add(data.fixList[i]);
                    }
                    else
                    {
                        expenses += data.fixList[i].money;
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightCoral;
                        historyEntries.Add(data.fixList[i]);
                    }
                }
                else if (data.fixList[i].period == "halbjährlich" && now.Month == data.fixList[i].datum.Month || (now.Month == data.fixList[i].datum.Month + 6) || (now.Month == data.fixList[i].datum.Month - 6))
                {
                    if (data.fixList[i].einnahme)
                    {
                        income += (data.fixList[i].money);
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightGreen;
                        historyEntries.Add(data.fixList[i]);
                    }
                    else
                    {
                        expenses += (data.fixList[i].money);
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightCoral;
                        historyEntries.Add(data.fixList[i]);
                    }
                }
                else if (data.fixList[i].period == "jährlich" && now.Month == data.fixList[i].datum.Month)
                {
                    if (data.fixList[i].einnahme)
                    {
                        income += (data.fixList[i].money);
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightGreen;
                        historyEntries.Add(data.fixList[i]);
                    }
                    else
                    {
                        expenses += (data.fixList[i].money);
                        listView1.Items[data.fixList.Count - 1 - i].BackColor = Color.LightCoral;
                        historyEntries.Add(data.fixList[i]);
                    }
                }
            }

            inc_label.Text = "" + income + " €";
            spend_label.Text = "" + expenses + " €";
            difference_label.Text = "" + (income - expenses) + " €";
        }

        private int WeeksInMonth()
        {
            DateTime today = DateTime.Today;
            int year = today.Year;
            int month = today.Month;

            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

            int mondayCount = 0;

            for (DateTime date = firstDay; date <= lastDay; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    mondayCount++;
                }
            }

            return mondayCount;
        }
        private void add_to_bookings()
        {
            DateTime now = DateTime.Now;
            bool inc_exists = false;
            int inc_index = -1;
            bool exp_exists = false;
            int exp_index = -1;

            for (int i = 0; i < data.datenList.Count; i++)
            {
                if(data.datenList[i].datum == new DateTime(now.Year, now.Month, 1) && data.datenList[i].usage == "Fixeinkommen" && data.datenList[i].fix == true)
                {
                    inc_exists = true;
                    inc_index = i;
                }
                if (data.datenList[i].datum == new DateTime(now.Year, now.Month, 1) && data.datenList[i].usage == "Fixausgaben" && data.datenList[i].fix == true)
                {
                    exp_exists = true;
                    exp_index = i;
                }
            }
            if (inc_exists) 
            { 
                data.datenList[inc_index] = new DataEntry
                {
                    datum = new DateTime(now.Year, now.Month, 1),
                    gebucht = false,
                    usage = "Fixeinkommen",
                    money = income,
                    einnahme = true,
                    fix = true
                };
            } else
            {
                data.datenList.Add(new DataEntry
                {
                    datum = new DateTime(now.Year, now.Month, 1),
                    gebucht = false,
                    usage = "Fixeinkommen",
                    money = income,
                    einnahme = true,
                    fix = true
                });
            }

            if (exp_exists)
            {
                data.datenList[exp_index] = new DataEntry
                {
                    datum = new DateTime(now.Year, now.Month, 1),
                    gebucht = false,
                    usage = "Fixausgaben",
                    money = expenses,
                    einnahme = false,
                    fix = true
                };
            }
            else
            {
                data.datenList.Add(new DataEntry
                {
                    datum = new DateTime(now.Year, now.Month, 1),
                    gebucht = false,
                    usage = "Fixausgaben",
                    money = expenses,
                    einnahme = false,
                    fix = true
                });
            }

            original_form.refresh_list();
        }
        private void add_to_history()
        {
            DateTime now = DateTime.Now;

            for (int i = 0; i < data.fixListHistory.Count; i++)
            {
                if (data.fixListHistory[i].datum == new DateTime(now.Year, now.Month, 1))
                {
                    data.fixListHistory.RemoveAt(i);
                }
            }
            for (int i = 0; i < historyEntries.Count; i++)
            {
                data.fixListHistory.Add(new DataFixEntry
                {
                    datum = new DateTime(now.Year, now.Month, 1),
                    usage = historyEntries[i].usage,
                    money = historyEntries[i].money,
                    period = historyEntries[i].period,
                    einnahme = historyEntries[i].einnahme
                });
            }
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
