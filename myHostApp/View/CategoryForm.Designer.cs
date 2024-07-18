namespace myHostApp
{
    partial class CategoryForm
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
            labelCategory = new Label();
            dataGridViewAll = new DataGridView();
            buttonAdd = new Button();
            textBoxFood = new TextBox();
            buttonOk = new Button();
            dataGridViewGuest = new DataGridView();
            buttonNext = new Button();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuest).BeginInit();
            SuspendLayout();
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(460, 36);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(59, 25);
            labelCategory.TabIndex = 0;
            labelCategory.Text = "label1";
            // 
            // dataGridViewAll
            // 
            dataGridViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAll.Location = new Point(34, 107);
            dataGridViewAll.Name = "dataGridViewAll";
            dataGridViewAll.RowHeadersWidth = 62;
            dataGridViewAll.Size = new Size(884, 225);
            dataGridViewAll.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(710, 364);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(137, 61);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "הוספת מאכל";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxFood
            // 
            textBoxFood.Enabled = false;
            textBoxFood.Location = new Point(383, 379);
            textBoxFood.Name = "textBoxFood";
            textBoxFood.Size = new Size(203, 31);
            textBoxFood.TabIndex = 3;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(129, 364);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(139, 61);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "אישור";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += this.buttonOk_Click;
            // 
            // dataGridViewGuest
            // 
            dataGridViewGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGuest.Location = new Point(34, 492);
            dataGridViewGuest.Name = "dataGridViewGuest";
            dataGridViewGuest.RowHeadersWidth = 62;
            dataGridViewGuest.Size = new Size(884, 225);
            dataGridViewGuest.TabIndex = 5;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(573, 742);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(211, 58);
            buttonNext.TabIndex = 6;
            buttonNext.Text = ">>";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(202, 742);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(198, 58);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "<<";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 828);
            Controls.Add(buttonBack);
            Controls.Add(buttonNext);
            Controls.Add(dataGridViewGuest);
            Controls.Add(buttonOk);
            Controls.Add(textBoxFood);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewAll);
            Controls.Add(labelCategory);
            Name = "CategoryForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCategory;
        private DataGridView dataGridViewAll;
        private Button buttonAdd;
        private TextBox textBoxFood;
        private Button buttonOk;
        private DataGridView dataGridViewGuest;
        private Button buttonNext;
        private Button buttonBack;
    }
}