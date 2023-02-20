using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>();

        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get 
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("You have not filled all the credentials");
                textBoxUsername.Focus();
            }
            else
            {
                bool found = false;
                foreach (User i in users)
                {
                    //sthn java anti gia == tha eprepe na xrhsimopoihsw Equals
                    if (textBoxUsername.Text == i.Username && textBoxPassword.Text == i.Password)
                    {
                        found = true;
                        MainApp mainapp = new MainApp(i.Username.ToString());
                        mainapp.Show();
                        // or: new MainApp().Show;
                        this.Hide();   
                        break;
                    }
                }
                if (!found)
                MessageBox.Show("You have entered an invalid username or password");

                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();
            }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Red;
            labelExit.Font = new Font("Bahnschrift", 17, FontStyle.Bold);
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.FromArgb(160, 192, 47);
            labelExit.Font = new Font("Bahnschrift", 15, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            users.Add(new User("alex", "123"));
            users.Add(new User("ioan", "123"));
            textBoxUsername.Focus();
        }
    }
}
