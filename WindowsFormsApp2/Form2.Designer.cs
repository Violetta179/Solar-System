namespace WindowsFormsApp2
{
    partial class Form2
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
            this.button1ADD = new System.Windows.Forms.Button();
            this.button2EDIT = new System.Windows.Forms.Button();
            this.button3DELETE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1ADD
            // 
            this.button1ADD.Location = new System.Drawing.Point(64, 271);
            this.button1ADD.Name = "button1ADD";
            this.button1ADD.Size = new System.Drawing.Size(105, 54);
            this.button1ADD.TabIndex = 0;
            this.button1ADD.Text = "Add";
            this.button1ADD.UseVisualStyleBackColor = true;
            this.button1ADD.Click += new System.EventHandler(this.button1ADD_Click);
            // 
            // button2EDIT
            // 
            this.button2EDIT.Location = new System.Drawing.Point(218, 271);
            this.button2EDIT.Name = "button2EDIT";
            this.button2EDIT.Size = new System.Drawing.Size(105, 54);
            this.button2EDIT.TabIndex = 1;
            this.button2EDIT.Text = "Edit";
            this.button2EDIT.UseVisualStyleBackColor = true;
            this.button2EDIT.Click += new System.EventHandler(this.button2EDIT_Click);
            // 
            // button3DELETE
            // 
            this.button3DELETE.Location = new System.Drawing.Point(366, 271);
            this.button3DELETE.Name = "button3DELETE";
            this.button3DELETE.Size = new System.Drawing.Size(104, 54);
            this.button3DELETE.TabIndex = 2;
            this.button3DELETE.Text = "delete";
            this.button3DELETE.UseVisualStyleBackColor = true;
            this.button3DELETE.Click += new System.EventHandler(this.button3DELETE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(538, 244);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 328);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3DELETE);
            this.Controls.Add(this.button2EDIT);
            this.Controls.Add(this.button1ADD);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1ADD;
        private System.Windows.Forms.Button button2EDIT;
        private System.Windows.Forms.Button button3DELETE;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}