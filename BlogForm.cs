using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogClient
{
    public partial class BlogForm : Form
    {
        public BlogForm()
        {
            InitializeComponent();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            string title = titleBox.Text;
            string author = authorBox.Text;
            string content = blogContent.Text;
            if (title.Length == 0)
            {
                MessageBox.Show("标题不能为空！");
                return;
            }
            if (author.Length == 0)
            {
                MessageBox.Show("作者不能为空！");
                return;
            }
            if (content.Length == 0)
            {
                MessageBox.Show("内容不能为空！");
                return;
            }
            MainForm.Client.AddBlog(title, author, content);
            MessageBox.Show("添加成功！");
            Close();
        }
    }
}
