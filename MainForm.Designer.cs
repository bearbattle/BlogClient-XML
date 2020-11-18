namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userList = new System.Windows.Forms.ListView();
            this.userButton = new System.Windows.Forms.Button();
            this.blogButton = new System.Windows.Forms.Button();
            this.blogList = new System.Windows.Forms.ListView();
            this.blogContent = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.commentList = new System.Windows.Forms.ListView();
            this.addUser = new System.Windows.Forms.Button();
            this.addBlog = new System.Windows.Forms.Button();
            this.addComment = new System.Windows.Forms.Button();
            this.commentContentBox = new System.Windows.Forms.RichTextBox();
            this.commentUserBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.userList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.blogButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.blogList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.blogContent, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.authorLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.commentList, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.addUser, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.addBlog, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.addComment, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.commentContentBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.commentUserBox, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.777778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1198, 642);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userList
            // 
            this.userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList.HideSelection = false;
            this.userList.Location = new System.Drawing.Point(3, 37);
            this.userList.MultiSelect = false;
            this.userList.Name = "userList";
            this.tableLayoutPanel1.SetRowSpan(this.userList, 3);
            this.userList.Size = new System.Drawing.Size(129, 572);
            this.userList.TabIndex = 0;
            this.userList.UseCompatibleStateImageBehavior = false;
            this.userList.View = System.Windows.Forms.View.List;
            // 
            // userButton
            // 
            this.userButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userButton.Location = new System.Drawing.Point(3, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(129, 28);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "查询用户信息";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // blogButton
            // 
            this.blogButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blogButton.Location = new System.Drawing.Point(138, 3);
            this.blogButton.Name = "blogButton";
            this.blogButton.Size = new System.Drawing.Size(129, 28);
            this.blogButton.TabIndex = 1;
            this.blogButton.Text = "查询所有博客";
            this.blogButton.UseVisualStyleBackColor = true;
            this.blogButton.Click += new System.EventHandler(this.blogButton_Click);
            // 
            // blogList
            // 
            this.blogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blogList.HideSelection = false;
            this.blogList.Location = new System.Drawing.Point(138, 37);
            this.blogList.MultiSelect = false;
            this.blogList.Name = "blogList";
            this.tableLayoutPanel1.SetRowSpan(this.blogList, 3);
            this.blogList.Size = new System.Drawing.Size(129, 572);
            this.blogList.TabIndex = 3;
            this.blogList.UseCompatibleStateImageBehavior = false;
            this.blogList.View = System.Windows.Forms.View.List;
            this.blogList.SelectedIndexChanged += new System.EventHandler(this.blogList_SelectedIndexChanged);
            // 
            // blogContent
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.blogContent, 2);
            this.blogContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blogContent.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blogContent.Location = new System.Drawing.Point(273, 37);
            this.blogContent.Name = "blogContent";
            this.blogContent.ReadOnly = true;
            this.blogContent.Size = new System.Drawing.Size(922, 401);
            this.blogContent.TabIndex = 4;
            this.blogContent.Text = "博客内容";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.Location = new System.Drawing.Point(273, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(633, 34);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "博客标题";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorLabel.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLabel.Location = new System.Drawing.Point(912, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(283, 34);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "作者";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // commentList
            // 
            this.commentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentList.HideSelection = false;
            this.commentList.Location = new System.Drawing.Point(273, 444);
            this.commentList.Name = "commentList";
            this.tableLayoutPanel1.SetRowSpan(this.commentList, 3);
            this.commentList.Size = new System.Drawing.Size(633, 195);
            this.commentList.TabIndex = 7;
            this.commentList.UseCompatibleStateImageBehavior = false;
            this.commentList.View = System.Windows.Forms.View.Tile;
            // 
            // addUser
            // 
            this.addUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUser.Location = new System.Drawing.Point(3, 615);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(129, 24);
            this.addUser.TabIndex = 8;
            this.addUser.Text = "添加用户";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // addBlog
            // 
            this.addBlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBlog.Location = new System.Drawing.Point(138, 615);
            this.addBlog.Name = "addBlog";
            this.addBlog.Size = new System.Drawing.Size(129, 24);
            this.addBlog.TabIndex = 9;
            this.addBlog.Text = "添加博客";
            this.addBlog.UseVisualStyleBackColor = true;
            this.addBlog.Click += new System.EventHandler(this.addBlog_Click);
            // 
            // addComment
            // 
            this.addComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addComment.Location = new System.Drawing.Point(912, 615);
            this.addComment.Name = "addComment";
            this.addComment.Size = new System.Drawing.Size(283, 24);
            this.addComment.TabIndex = 10;
            this.addComment.Text = "添加评论";
            this.addComment.UseVisualStyleBackColor = true;
            this.addComment.Click += new System.EventHandler(this.addComment_Click);
            // 
            // commentContentBox
            // 
            this.commentContentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentContentBox.Location = new System.Drawing.Point(912, 472);
            this.commentContentBox.Name = "commentContentBox";
            this.commentContentBox.Size = new System.Drawing.Size(283, 137);
            this.commentContentBox.TabIndex = 11;
            this.commentContentBox.Text = "";
            // 
            // commentUserBox
            // 
            this.commentUserBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentUserBox.Location = new System.Drawing.Point(912, 444);
            this.commentUserBox.Name = "commentUserBox";
            this.commentUserBox.Size = new System.Drawing.Size(283, 21);
            this.commentUserBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "博客客户端窗口";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button blogButton;
        private System.Windows.Forms.ListView userList;
        private System.Windows.Forms.ListView blogList;
        private System.Windows.Forms.RichTextBox blogContent;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ListView commentList;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button addBlog;
        private System.Windows.Forms.Button addComment;
        private System.Windows.Forms.RichTextBox commentContentBox;
        private System.Windows.Forms.TextBox commentUserBox;
    }
}