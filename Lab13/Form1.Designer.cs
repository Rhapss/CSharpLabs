namespace Lab13
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.PanelNumbers = new System.Windows.Forms.Panel();
            this.TabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage1);
            this.TabControl.Controls.Add(this.TabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(208, 242);
            this.TabControl.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.ComboBox);
            this.TabPage1.Controls.Add(this.RemoveButton);
            this.TabPage1.Controls.Add(this.AddButton);
            this.TabPage1.Controls.Add(this.TextBox);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(200, 214);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Task 1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // ComboBox
            // 
            this.ComboBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(3, 106);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(194, 23);
            this.ComboBox.TabIndex = 4;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveButton.Location = new System.Drawing.Point(3, 66);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(194, 40);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Delete";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Location = new System.Drawing.Point(3, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(194, 40);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.Location = new System.Drawing.Point(3, 3);
            this.TextBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(194, 23);
            this.TextBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(96, -15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Enter text here:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.PanelNumbers);
            this.TabPage2.Location = new System.Drawing.Point(4, 24);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(200, 214);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Task 2";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelNumbers
            // 
            this.PanelNumbers.AutoScroll = true;
            this.PanelNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNumbers.Location = new System.Drawing.Point(3, 3);
            this.PanelNumbers.Name = "PanelNumbers";
            this.PanelNumbers.Size = new System.Drawing.Size(194, 244);
            this.PanelNumbers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 242);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.TabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel PanelNumbers;
    }
}
