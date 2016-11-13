namespace TimeClock
{
    partial class Form1
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_punchin = new System.Windows.Forms.Button();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.lst_out = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 49);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(266, 20);
            this.txt_name.TabIndex = 0;
            // 
            // btn_punchin
            // 
            this.btn_punchin.Location = new System.Drawing.Point(284, 45);
            this.btn_punchin.Name = "btn_punchin";
            this.btn_punchin.Size = new System.Drawing.Size(116, 26);
            this.btn_punchin.TabIndex = 1;
            this.btn_punchin.Text = "Punch In";
            this.btn_punchin.UseVisualStyleBackColor = true;
            this.btn_punchin.Click += new System.EventHandler(this.btn_punchin_Click);
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.Location = new System.Drawing.Point(56, 22);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(314, 13);
            this.lbl_instructions.TabIndex = 2;
            this.lbl_instructions.Text = "Instructions: Enter your name in the box below and click punch in";
            // 
            // lst_out
            // 
            this.lst_out.FormattingEnabled = true;
            this.lst_out.Location = new System.Drawing.Point(12, 106);
            this.lst_out.Name = "lst_out";
            this.lst_out.Size = new System.Drawing.Size(394, 199);
            this.lst_out.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset PW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "ListSettings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_out);
            this.Controls.Add(this.lbl_instructions);
            this.Controls.Add(this.btn_punchin);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = "Time Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_punchin;
        private System.Windows.Forms.Label lbl_instructions;
        private System.Windows.Forms.ListBox lst_out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

