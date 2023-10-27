namespace Yolov8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            tb_model_path = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_choose_testimage = new Button();
            btn_choose_claspath = new Button();
            tb_test_image = new TextBox();
            tb_clas_path = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(466, 205);
            button1.Name = "button1";
            button1.Size = new Size(187, 47);
            button1.TabIndex = 0;
            button1.Text = "预测";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb_model_path
            // 
            tb_model_path.Location = new Point(270, 23);
            tb_model_path.Name = "tb_model_path";
            tb_model_path.Size = new Size(400, 27);
            tb_model_path.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(755, 23);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "选择";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(36, 289);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 504);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.AppWorkspace;
            pictureBox2.Location = new Point(627, 289);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(459, 504);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // btn_choose_testimage
            // 
            btn_choose_testimage.Location = new Point(896, 138);
            btn_choose_testimage.Margin = new Padding(4);
            btn_choose_testimage.Name = "btn_choose_testimage";
            btn_choose_testimage.Size = new Size(73, 31);
            btn_choose_testimage.TabIndex = 17;
            btn_choose_testimage.Text = "选 择";
            btn_choose_testimage.UseVisualStyleBackColor = true;
            btn_choose_testimage.Click += btn_choose_testimage_Click;
            // 
            // btn_choose_claspath
            // 
            btn_choose_claspath.Location = new Point(896, 83);
            btn_choose_claspath.Margin = new Padding(4);
            btn_choose_claspath.Name = "btn_choose_claspath";
            btn_choose_claspath.Size = new Size(73, 31);
            btn_choose_claspath.TabIndex = 18;
            btn_choose_claspath.Text = "选 择";
            btn_choose_claspath.UseVisualStyleBackColor = true;
            btn_choose_claspath.Click += btn_choose_claspath_Click;
            // 
            // tb_test_image
            // 
            tb_test_image.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_test_image.Location = new Point(237, 139);
            tb_test_image.Margin = new Padding(4);
            tb_test_image.Name = "tb_test_image";
            tb_test_image.Size = new Size(628, 30);
            tb_test_image.TabIndex = 15;
            // 
            // tb_clas_path
            // 
            tb_clas_path.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_clas_path.Location = new Point(237, 84);
            tb_clas_path.Margin = new Padding(4);
            tb_clas_path.Name = "tb_clas_path";
            tb_clas_path.Size = new Size(628, 30);
            tb_clas_path.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(127, 143);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 13;
            label4.Text = "测试图片:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(127, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 14;
            label3.Text = "类别文件:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(127, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 19;
            label2.Text = "推理模型:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 806);
            Controls.Add(label2);
            Controls.Add(btn_choose_testimage);
            Controls.Add(btn_choose_claspath);
            Controls.Add(tb_test_image);
            Controls.Add(tb_clas_path);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(tb_model_path);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tb_model_path;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_choose_testimage;
        private Button btn_choose_claspath;
        private TextBox tb_test_image;
        private TextBox tb_clas_path;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}