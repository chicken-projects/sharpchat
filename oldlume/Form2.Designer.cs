namespace lume_executor
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
            settingsbutton = new Button();
            homebutton = new Button();
            minimizebutton = new Button();
            closebutton = new Button();
            toolStrip1 = new ToolStrip();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // settingsbutton
            // 
            settingsbutton.BackColor = Color.FromArgb(45, 45, 45);
            settingsbutton.FlatAppearance.BorderSize = 0;
            settingsbutton.FlatStyle = FlatStyle.Flat;
            settingsbutton.Font = new Font("Georgia", 8.25F);
            settingsbutton.ForeColor = Color.White;
            settingsbutton.Location = new Point(4, 85);
            settingsbutton.Name = "settingsbutton";
            settingsbutton.Size = new Size(44, 44);
            settingsbutton.TabIndex = 19;
            settingsbutton.Text = "settings";
            settingsbutton.UseVisualStyleBackColor = false;
            settingsbutton.Click += settingsbutton_Click;
            // 
            // homebutton
            // 
            homebutton.BackColor = Color.FromArgb(45, 45, 45);
            homebutton.FlatAppearance.BorderSize = 0;
            homebutton.FlatStyle = FlatStyle.Flat;
            homebutton.Font = new Font("Georgia", 8.25F);
            homebutton.ForeColor = Color.White;
            homebutton.Location = new Point(4, 35);
            homebutton.Name = "homebutton";
            homebutton.Size = new Size(44, 44);
            homebutton.TabIndex = 17;
            homebutton.Text = "home";
            homebutton.UseVisualStyleBackColor = false;
            homebutton.Click += homebutton_Click;
            // 
            // minimizebutton
            // 
            minimizebutton.BackColor = Color.DimGray;
            minimizebutton.FlatAppearance.BorderSize = 0;
            minimizebutton.FlatStyle = FlatStyle.Flat;
            minimizebutton.Font = new Font("Georgia", 8.25F);
            minimizebutton.ForeColor = Color.White;
            minimizebutton.Location = new Point(704, 0);
            minimizebutton.Name = "minimizebutton";
            minimizebutton.Size = new Size(48, 25);
            minimizebutton.TabIndex = 16;
            minimizebutton.Text = "minimize";
            minimizebutton.UseVisualStyleBackColor = false;
            minimizebutton.Click += minimizebutton_Click;
            // 
            // closebutton
            // 
            closebutton.BackColor = Color.DimGray;
            closebutton.FlatAppearance.BorderSize = 0;
            closebutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            closebutton.FlatAppearance.MouseOverBackColor = Color.Red;
            closebutton.FlatStyle = FlatStyle.Flat;
            closebutton.Font = new Font("Georgia", 8.25F);
            closebutton.ForeColor = Color.White;
            closebutton.Location = new Point(752, 0);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(48, 25);
            closebutton.TabIndex = 14;
            closebutton.Text = "close";
            closebutton.UseVisualStyleBackColor = false;
            closebutton.Click += closebutton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Georgia", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(112, 49);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 18);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(settingsbutton);
            Controls.Add(homebutton);
            Controls.Add(minimizebutton);
            Controls.Add(closebutton);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button settingsbutton;
        private Button homebutton;
        private Button minimizebutton;
        private Button closebutton;
        private ToolStrip toolStrip1;
        private CheckBox checkBox1;
    }
}