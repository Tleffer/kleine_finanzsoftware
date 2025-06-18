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
    public partial class FormDelete : Form
    {
        int index;
        Daten data;
        Object form;
        bool fix;
        public FormDelete(int index, Daten data, Object form, bool fix)
        {
            InitializeComponent();
            this.index = index;
            this.data = data;
            this.form = form;
            this.fix = fix;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (fix)
            {
                data.fixList.RemoveAt(index);
            } else
            {
                if(data.datenList[index].fix)
                {
                    MessageBox.Show("Diese Buchung ist eine Fixbuchung und kann nicht gelöscht werden.");
                    try
                    {
                        Form1 form = (Form1)this.form;
                        form.delete_mode = false;
                        form.listView1.BackColor = Color.LightGray;
                        form.groupBoxButtons.BackColor = Color.DimGray;
                    }
                    catch (Exception ex) { }
                    try
                    {
                        FormFix form = (FormFix)this.form;
                        form.delete_mode = false;
                        form.listView1.BackColor = Color.LightGray;
                        form.groupBoxButtons.BackColor = Color.DimGray;
                    }
                    catch (Exception ex) { }
                    this.Close();
                    return;
                } else
                {
                    data.datenList.RemoveAt(index);
                }
                    
            }
            
            try
            {
                Form1 form = (Form1)this.form;
                form.refresh_list();
                form.delete_mode = false;
                form.listView1.BackColor = Color.LightGray;
                form.groupBoxButtons.BackColor = Color.DimGray;
            }
            catch (Exception ex) { }
            try
            {
                FormFix form = (FormFix)this.form;
                form.refresh_list();
                form.delete_mode = false;
                form.listView1.BackColor = Color.LightGray;
                form.groupBoxButtons.BackColor = Color.DimGray;
            }
            catch (Exception ex) { }
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form = (Form1)this.form;
                form.delete_mode = false;
                form.listView1.BackColor = Color.LightGray;
                form.groupBoxButtons.BackColor = Color.DimGray;
            }
            catch (Exception ex) { }
            try
            {
                FormFix form = (FormFix)this.form;
                form.delete_mode = false;
                form.listView1.BackColor = Color.LightGray;
                form.groupBoxButtons.BackColor = Color.DimGray;
            }
            catch (Exception ex) { }
            this.Close();
        }
    }
}
