using BlogClient.BlogService;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static BlogService.BlogServiceSoapClient Client = new BlogServiceSoapClient();
        BlogService.UserInfo[] users;
        BlogService.BlogInfo[] blogs;
        BlogService.BlogDetail curBlog;
        BlogService.CommentInfo[] comments;

        private void RefreshUserList()
        {
            users = Client.GetUsers();
            userList.Items.Clear();
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = user.Username,
                    Tag = user.Id
                };
                userList.Items.Add(item);
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void RefreshBlogList()
        {
            if (userList.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = userList.SelectedItems[0];
                blogs = Client.GetBlogs(selectedItem.Tag.ToString());
                blogList.Items.Clear();
                foreach (var blog in blogs)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Text = blog.Title,
                        Tag = blog.Id
                    };
                    blogList.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("请先在在左侧的列表选择一个用户！");
            }
        }

        private void blogButton_Click(object sender, EventArgs e)
        {
            RefreshBlogList();
        }

        private void GetBlog()
        {
            if (blogList.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = blogList.SelectedItems[0];
                curBlog = Client.GetBlogDetail(selectedItem.Tag.ToString());
                titleLabel.Text = curBlog.Title;
                authorLabel.Text = curBlog.Author + " Posted at " + curBlog.UpdateTime;
                blogContent.Text = curBlog.Content;
            }
        }

        private void GetBlogComments()
        {
            if (blogList.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = blogList.SelectedItems[0];
                comments = Client.GetBlogComments(selectedItem.Tag.ToString());
                commentList.Items.Clear();
                foreach (var comment in comments)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Text = $"Commented by {comment.Author}\n {comment.Content}"
                    };
                    commentList.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("请先在在中间的列表选择一个博客！");
            }
        }

        private void blogList_SelectedIndexChanged(object sender, EventArgs e)
        {
            curBlog = null;
            GetBlog();
            GetBlogComments();
        }

        public string newUsername { get; set; }

        private void AddBlogComment()
        {
            string commentUsername = commentUserBox.Text;
            string commentContent = commentContentBox.Text;
            if (curBlog == null)
            {
                MessageBox.Show("请先选择一个博客！");
                return;
            }
            if (commentUsername.Length == 0)
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (commentContent.Length == 0)
            {
                MessageBox.Show("评论内容不能为空！");
                return;
            }
            Client.AddBlogComment(curBlog.Id, commentUsername, commentContent);
            commentUserBox.Clear();
            commentContentBox.Clear();
        }

        private void addComment_Click(object sender, EventArgs e)
        {
            AddBlogComment();
            GetBlogComments();
            RefreshUserList();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            new AddUser().Show();
            RefreshUserList();
        }

        private void addBlog_Click(object sender, EventArgs e)
        {
            new BlogForm().Show();
            RefreshUserList();
            RefreshBlogList();
        }
    }
}
