namespace Minimax_TicToe_
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(2, 3);
            this.bt1.Margin = new System.Windows.Forms.Padding(5);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(131, 111);
            this.bt1.TabIndex = 0;
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button_click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(134, 3);
            this.bt2.Margin = new System.Windows.Forms.Padding(5);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(131, 111);
            this.bt2.TabIndex = 1;
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.button_click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(266, 3);
            this.bt3.Margin = new System.Windows.Forms.Padding(5);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(131, 111);
            this.bt3.TabIndex = 2;
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.button_click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(2, 115);
            this.bt4.Margin = new System.Windows.Forms.Padding(5);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(131, 111);
            this.bt4.TabIndex = 3;
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.button_click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(134, 115);
            this.bt5.Margin = new System.Windows.Forms.Padding(5);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(131, 111);
            this.bt5.TabIndex = 4;
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.button_click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(266, 115);
            this.bt6.Margin = new System.Windows.Forms.Padding(5);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(131, 111);
            this.bt6.TabIndex = 5;
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.button_click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(2, 227);
            this.bt7.Margin = new System.Windows.Forms.Padding(5);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(131, 111);
            this.bt7.TabIndex = 6;
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.button_click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(134, 227);
            this.bt8.Margin = new System.Windows.Forms.Padding(5);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(131, 111);
            this.bt8.TabIndex = 7;
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.button_click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(266, 227);
            this.bt9.Margin = new System.Windows.Forms.Padding(5);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(131, 111);
            this.bt9.TabIndex = 8;
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(399, 340);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private IBoard gmBoard;
    }
}

