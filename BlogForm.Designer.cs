namespace WindowsFormsApp1
{
    partial class BlogForm
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
            this.blogContent = new System.Windows.Forms.RichTextBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // blogContent
            // 
            this.blogContent.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blogContent.Location = new System.Drawing.Point(21, 77);
            this.blogContent.Name = "blogContent";
            this.blogContent.Size = new System.Drawing.Size(767, 422);
            this.blogContent.TabIndex = 7;
            this.blogContent.Text = "博客内容";
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(21, 505);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(767, 23);
            this.actionButton.TabIndex = 8;
            this.actionButton.Text = "确定";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleBox.Location = new System.Drawing.Point(21, 13);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(767, 31);
            this.titleBox.TabIndex = 9;
            this.titleBox.Text = "标题";
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(21, 50);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(767, 21);
            this.authorBox.TabIndex = 10;
            this.authorBox.Text = "作者";
            // 
            // BlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.blogContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BlogForm";
            this.Text = "添加博客";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox blogContent;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
    }
}