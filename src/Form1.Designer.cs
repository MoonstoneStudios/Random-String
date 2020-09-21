namespace RandomString
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
            this.components = new System.ComponentModel.Container();
            this.regenButton = new System.Windows.Forms.Button();
            this.numberOfChars = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.repeatChars = new System.Windows.Forms.CheckBox();
            this.options = new System.Windows.Forms.GroupBox();
            this.includeSymbols = new System.Windows.Forms.CheckBox();
            this.includeNumbers = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // regenButton
            // 
            this.regenButton.BackColor = System.Drawing.Color.PaleGreen;
            this.regenButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regenButton.Location = new System.Drawing.Point(479, 498);
            this.regenButton.Name = "regenButton";
            this.regenButton.Size = new System.Drawing.Size(292, 114);
            this.regenButton.TabIndex = 0;
            this.regenButton.Text = "Start";
            this.regenButton.UseVisualStyleBackColor = false;
            this.regenButton.Click += new System.EventHandler(this.regenButton_Click);
            // 
            // numberOfChars
            // 
            this.numberOfChars.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberOfChars.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfChars.Location = new System.Drawing.Point(479, 428);
            this.numberOfChars.Name = "numberOfChars";
            this.numberOfChars.Size = new System.Drawing.Size(292, 64);
            this.numberOfChars.TabIndex = 1;
            this.numberOfChars.Text = "5";
            this.numberOfChars.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(-2, 60);
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(803, 253);
            this.result.TabIndex = 2;
            this.result.Text = "Result Goes Here";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.result, "Double Click To Copy To Clipboard");
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Letters:";
            // 
            // repeatChars
            // 
            this.repeatChars.AutoSize = true;
            this.repeatChars.Location = new System.Drawing.Point(15, 40);
            this.repeatChars.Name = "repeatChars";
            this.repeatChars.Size = new System.Drawing.Size(197, 28);
            this.repeatChars.TabIndex = 0;
            this.repeatChars.Text = "Repeat Letters";
            this.repeatChars.UseVisualStyleBackColor = true;
            // 
            // options
            // 
            this.options.Controls.Add(this.includeSymbols);
            this.options.Controls.Add(this.includeNumbers);
            this.options.Controls.Add(this.repeatChars);
            this.options.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.Location = new System.Drawing.Point(37, 407);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(348, 204);
            this.options.TabIndex = 4;
            this.options.TabStop = false;
            this.options.Text = "Options";
            // 
            // includeSymbols
            // 
            this.includeSymbols.AutoSize = true;
            this.includeSymbols.Location = new System.Drawing.Point(15, 108);
            this.includeSymbols.Name = "includeSymbols";
            this.includeSymbols.Size = new System.Drawing.Size(209, 28);
            this.includeSymbols.TabIndex = 2;
            this.includeSymbols.Text = "Include Symbols";
            this.includeSymbols.UseVisualStyleBackColor = true;
            // 
            // includeNumbers
            // 
            this.includeNumbers.AutoSize = true;
            this.includeNumbers.Location = new System.Drawing.Point(15, 74);
            this.includeNumbers.Name = "includeNumbers";
            this.includeNumbers.Size = new System.Drawing.Size(209, 28);
            this.includeNumbers.TabIndex = 1;
            this.includeNumbers.Text = "Include Numbers";
            this.includeNumbers.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Tip:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.numberOfChars);
            this.Controls.Add(this.regenButton);
            this.Name = "Form1";
            this.Text = "RandomString";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regenButton;
        private System.Windows.Forms.TextBox numberOfChars;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox repeatChars;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.CheckBox includeSymbols;
        private System.Windows.Forms.CheckBox includeNumbers;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

