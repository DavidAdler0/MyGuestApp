namespace myHostApp
{
    partial class MainForm
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
            labelWelcome = new Label();
            labelEnterName = new Label();
            textBoxName = new TextBox();
            buttonLogin = new Button();
            listBoxNames = new ListBox();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(232, 41);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(119, 25);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "ברוכים הבאים";
            // 
            // labelEnterName
            // 
            labelEnterName.AutoSize = true;
            labelEnterName.Location = new Point(232, 106);
            labelEnterName.Name = "labelEnterName";
            labelEnterName.Size = new Size(127, 25);
            labelEnterName.TabIndex = 1;
            labelEnterName.Text = "הכנס שם אורח";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(211, 163);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(239, 605);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 34);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "אישור";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += this.buttonLogin_Click;
            // 
            // listBoxNames
            // 
            listBoxNames.FormattingEnabled = true;
            listBoxNames.ItemHeight = 25;
            listBoxNames.Location = new Point(152, 224);
            listBoxNames.Name = "listBoxNames";
            listBoxNames.Size = new Size(270, 354);
            listBoxNames.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 651);
            Controls.Add(listBoxNames);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxName);
            Controls.Add(labelEnterName);
            Controls.Add(labelWelcome);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelEnterName;
        private TextBox textBoxName;
        private Button buttonLogin;
        private ListBox listBoxNames;
    }
}
