using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace kleine_Finanzsoftware
{
    public partial class Form1 : Form
    {
        public Daten data;
        public bool delete_mode = false;
        public bool edit_mode = false;

        double income;
        double expenses;
        double open;
        FormFix fixForm;
        public FormStats statsForm;
        Save save;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            save = new Save();
            if (save.pref_exists)
            {
                data = save.LoadData();
                if (data == null)
                {
                    FormPref formPref = new FormPref(this, save, true);
                    formPref.Show();
                    while (formPref.Visible)
                    {
                        Application.DoEvents(); // Wait for the preferences form to close
                    }
                }
            } else
            {
                FormPref formPref = new FormPref(this, save, true);
                formPref.Show();
                while (formPref.Visible)
                {
                    Application.DoEvents(); // Wait for the preferences form to close
                }
            }
            
            if(data == null)
            {
                this.Close();
                return;
            }

            //data.datenList.Add(new DataEntry { money = 1000, gebucht = false, usage = "ashjgdzusdaz", datum = DateTime.Now, einnahme = true });
            //data.datenList.Add(new DataEntry { money = 2000, gebucht = false, usage = "ashjgdzusdaz", einnahme = false, datum = DateTime.Now });


            this.WindowState = FormWindowState.Maximized;
            //this.Size = new System.Drawing.Size(1920, 1080);

            listView1.Size = new System.Drawing.Size(this.Width / 100 * 95, this.Height / 100 * 80);
            usage.Width = listView1.Width / 50 *26;
            date.Width = listView1.Width / 50 * 6;
            date.DisplayIndex = 1;
            money.Width = listView1.Width / 50 *12;
            abgebucht.Width = listView1.Width / 200 * 22;


            groupBoxButtons.Location = new Point(Width / 100 * 2, Height / 100 * 87);
            groupBoxButtons.Size = new Size(Width / 100 * 62, Height / 100 * 13);

            delete_button.Location = new Point(Width / 100 * 4, Height / 100* 89);
            edit_button.Location = new Point(Width / 100 * 20, Height / 100 * 89);
            add_button.Location = new Point(Width / 100 * 36, Height / 100 * 89);
            import_button.Location = new Point(Width / 100 * 52, Height / 100 * 89);

            einnahmen_ausgaben_bt.Location = new Point(Width / 100 * 3, Height / 100 * 1);
            fix_bt.Location = new Point(Width / 100 * 15, Height / 100 * 1);
            stats_button.Location = new Point(Width / 100 * 27, Height / 100 * 1);

            save_bt.Location = new Point(Width / 100 * 94, Height / 100 * 1);
            pref_button.Location = new Point(Width / 100 * 98, Height / 100 * 1);

            finance_box.Location = new Point(Width / 100 * 78, Height / 100 * 87);

            
            refresh_list();


            fixForm = new FormFix(data, this, statsForm, save);

            statsForm = new FormStats(data, this, fixForm, save);
            fixForm.Show();
            fixForm.Hide();
            statsForm.Show();
            statsForm.Hide();

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int selected_index = listView1.SelectedIndices[0];
            int list_index = data.datenList.Count - selected_index - 1;
            if(delete_mode)
            {
                FormDelete delf = new FormDelete(list_index, data, this, false);
                delf.Show();
            }
            else if (edit_mode)
            {
                FormEdit editForm = new FormEdit(list_index, data, this, false);
                editForm.Show();
            }
            else
            {
                if(!data.datenList[list_index].einnahme)
                {
                    data.datenList[list_index].gebucht = !data.datenList[list_index].gebucht;
                    refresh_list();
                }
            }


        }

        public void refresh_list()
        {
            data.datenList = data.datenList.OrderBy(entry => entry.datum).ToList();
            listView1.Items.Clear();

            income = 0;
            expenses = 0;
            open = 0;

            for (int i = data.datenList.Count - 1; i >= 0; i--)
            {
                //MessageBox.Show("" + i);
                String[] entry = new string[4];
                entry[0] = data.datenList[i].usage;

                entry[1] = data.datenList[i].datum.ToString();
                if (data.datenList[i].einnahme)
                {
                    entry[2] = "" + data.datenList[i].money.ToString() + " €";
                } else
                {
                    entry[2] = "-" + data.datenList[i].money.ToString() + " €";
                } 
                if (data.datenList[i].einnahme == false && data.datenList[i].gebucht)
                {
                    entry[3] = "Ja";
                }
                else if(data.datenList[i].einnahme == false)
                {
                    entry[3] = "Nein";
                } else if (data.datenList[i].einnahme == true)
                {
                    entry[3] = "Einnahme";
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

                if (data.datenList[i].gebucht == false && data.datenList[i].einnahme == false)
                {
                    open += data.datenList[i].money;
                }

                if (IsInCurrentMonth(data.datenList[i].datum))
                {
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

            inc_label.Text = "" + income + " €";
            spend_label.Text = "" + expenses + " €";
            remaining_label.Text = "" + open + " €";
            difference_label.Text = "" + (income - expenses) + " €";

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
            FormAdd addForm = new FormAdd(data, this, false);
            addForm.Show();
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

        private void stats_button_Click(object sender, EventArgs e)
        {
            save.SaveData(data);
            statsForm.Show();
            this.Hide();
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            save.SaveData(data);
        }

        public void pref_button_Click(object sender, EventArgs e)
        {
            FormPref formPref = new FormPref(this, save, false);
            formPref.Show();
            while (formPref.Visible)
            {
                Application.DoEvents(); // Wait for the preferences form to close
            }
            refresh_list();
            fixForm.data = data;
            statsForm.data = data;
            fixForm.refresh_list();
            statsForm.refresh_list();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            save.SaveData(data);
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "FinEntry files (*.finentry)|*.finentry",
                Title = "Select a file",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                path = openFileDialog.FileName;

                FileStream fs = new FileStream(path, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Export));
                Export importData = (Export)serializer.Deserialize(fs);
                fs.Close();

                MessageBox.Show("Importiere " + importData.Data.Count + " Einträge.");

                for (int i = 0; i < importData.Data.Count; i++)
                {
                    data.datenList.Add(new DataEntry {
                        fix = false, datum = importData.Data[i].date,
                        einnahme = importData.Data[i].einnahme,
                        gebucht = importData.Data[i].gebucht, 
                        money = importData.Data[i].amount,
                        usage = importData.Data[i].usage
                    });
                }
                save.SaveData(data);
                refresh_list();
            }
        }
    }
}
