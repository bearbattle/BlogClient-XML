using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }


        private void addUserBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            if (username.Length == 0)
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            MainForm.Client.AddUser(username);
            MessageBox.Show($"用户 {username} 添加成功！");
            usernameBox.Clear();
            Close();
        }
    }
}
