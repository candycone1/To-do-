namespace To_Do_List
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
            dataGridView1 = new DataGridView();
            fileSystemWatcher1 = new FileSystemWatcher();
            txt1 = new TextBox();
            button1 = new Button();
            txt2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            btn3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(428, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(233, 394);
            dataGridView1.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txt1
            // 
            txt1.Location = new Point(110, 101);
            txt1.Name = "txt1";
            txt1.Size = new Size(242, 23);
            txt1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(110, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 45);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt2
            // 
            txt2.Location = new Point(110, 161);
            txt2.Name = "txt2";
            txt2.Size = new Size(242, 23);
            txt2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 101);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Task name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 169);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "To Do";
            // 
            // button2
            // 
            button2.Location = new Point(191, 230);
            button2.Name = "button2";
            button2.Size = new Size(75, 45);
            button2.TabIndex = 6;
            button2.Text = "Updaate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(272, 230);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 45);
            btn3.TabIndex = 7;
            btn3.Text = "Delete";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(btn3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt2);
            Controls.Add(button1);
            Controls.Add(txt1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txt1;
        private Button button1;
        private TextBox txt2;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btn3;
    }
}
