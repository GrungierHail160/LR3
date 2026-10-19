using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Кузнецов_23ИС_ПР3.ADO.NET;

namespace Кузнецов_23ИС_ПР3
{
    public partial class FormDirector : Form
    {
        public FormDirector()
        {
            InitializeComponent();
        }

        private void FormDirector_Load(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            label2.Text = FormAutorization.Enter_User.First_Name + " " + FormAutorization.Enter_User.Second_Name;
            label3.Text = model.Roles.First(x => x.ID == FormAutorization.Enter_User.RoleID).Name;
            pictureBox1.Image = Image.FromFile(@"Photo\" + FormAutorization.Enter_User.Pictures);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
