namespace BubbleSort
{
    partial class frmBubbleSort
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBubbleSort = new System.Windows.Forms.Button();
            this.txtBubbleSort = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.txtArray);
            this.groupBox1.Location = new System.Drawing.Point(31, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерація масиву";
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(205, 21);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 51;
            this.dgvMass.RowTemplate.Height = 29;
            this.dgvMass.Size = new System.Drawing.Size(600, 140);
            this.dgvMass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть кількість\r\nелементів масиву:";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(205, 182);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(343, 29);
            this.btGenerate.TabIndex = 1;
            this.btGenerate.Text = "Згенерувати порожній масив";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(35, 119);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(125, 27);
            this.txtArray.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btBubbleSort);
            this.groupBox2.Controls.Add(this.txtBubbleSort);
            this.groupBox2.Location = new System.Drawing.Point(31, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "«Бульбашкове» сортування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Масив після сортування:";
            // 
            // btBubbleSort
            // 
            this.btBubbleSort.Location = new System.Drawing.Point(20, 38);
            this.btBubbleSort.Name = "btBubbleSort";
            this.btBubbleSort.Size = new System.Drawing.Size(140, 85);
            this.btBubbleSort.TabIndex = 1;
            this.btBubbleSort.Text = "Сортувати";
            this.btBubbleSort.UseVisualStyleBackColor = true;
            this.btBubbleSort.Click += new System.EventHandler(this.btBubbleSort_Click);
            // 
            // txtBubbleSort
            // 
            this.txtBubbleSort.Location = new System.Drawing.Point(205, 67);
            this.txtBubbleSort.Name = "txtBubbleSort";
            this.txtBubbleSort.Size = new System.Drawing.Size(600, 27);
            this.txtBubbleSort.TabIndex = 0;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(377, 405);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(146, 38);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmBubbleSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 455);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmBubbleSort";
            this.Text = "Сортування «бульбашкою»";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvMass;
        private Label label1;
        private Button btGenerate;
        private TextBox txtArray;
        private GroupBox groupBox2;
        private Label label2;
        private Button btBubbleSort;
        private TextBox txtBubbleSort;
        private Button btExit;
    }
}