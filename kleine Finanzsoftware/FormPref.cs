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
    public partial class FormPref : Form
    {
        Form1 mainForm;
        Save save;
        bool accepted = false;
        string path;
        ulong count;
        bool selected = false;
        int newFile = -1;
        bool first;
        public FormPref(Form1 mainForm, Save save, bool first)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.save = save;
            this.first = first;
        }

        private void load_search_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                Title = "Select a file",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog.FileName;
                path = filePath.Split('&')[0];
                count = Convert.ToUInt64(filePath.Split('&')[1].Split('.')[0]);

                load_field.Text = filePath;
                selected = true;
                newFile = 0;
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(selected)
            {
                save.prefData.Path = path;
                save.filePath = path;
                save.prefData.count = count;

                save.SavePrefernce();
                
                if(newFile == 0)
                {
                    mainForm.data = save.LoadData();
                }
                else if(newFile == 1)
                {
                    mainForm.data = new Daten();
                }
                else
                {
                    return;
                }

                accepted = true;
                this.Close();
            }
        }

        private void FormPref_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (!accepted)
            {
                mainForm.Close();
            }*/
        }

        private void new_search_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                Title = "Save file as",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = saveFileDialog.FileName;
                //MessageBox.Show("" + filePath);
                path = filePath.Split('.')[0];
                count = 0;
                new_field.Text = filePath;
                selected = true;
                newFile = 1;
            }
        }

        private void create_new_bt_CheckedChanged(object sender, EventArgs e)
        {
            if(create_new_bt.Checked)
            {
                load_search.BackColor = Color.LightGray;
                new_search.BackColor = Color.SteelBlue;
                new_search.Enabled = true;
                new_field.Enabled = true;
                load_search.Enabled = false;
                load_field.Enabled = false;
                load_data_bt.Checked = false;
            }
            else
            {
                new_search.Enabled = false;
                new_field.Enabled = false;
            }
        }

        private void load_data_bt_CheckedChanged(object sender, EventArgs e)
        {
            if (load_data_bt.Checked)
            {
                load_search.BackColor = Color.SteelBlue;
                new_search.BackColor = Color.LightGray;
                load_search.Enabled = true;
                load_field.Enabled = true;
                new_search.Enabled = false;
                new_field.Enabled = false;
                create_new_bt.Checked = false;
            }
            else
            {
                load_search.Enabled = false;
                load_field.Enabled = false;
            }
        }

        private void FormPref_Load(object sender, EventArgs e)
        {
            if(!first)
            {
                load_data_bt.Checked = true;
                create_new_bt.Checked = false;
                load_search.Enabled = true;
                load_search.BackColor = Color.SteelBlue;
                new_search.BackColor = Color.LightGray;
                new_search.Enabled = false;
                new_field.Enabled = false;
                load_field.Enabled = true;

                load_field.Text = save.prefData.Path + "&" + save.prefData.count + ".xml";
            }
        }
    }
}
