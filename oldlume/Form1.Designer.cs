namespace lume_executor
{
    partial class lumeexecutor
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
            closebutton = new Button();
            toolStrip1 = new ToolStrip();
            minimizebutton = new Button();
            scripttext = new RichTextBox();
            executescriptbutton = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            savefilebutton = new Button();
            openfilebutton = new Button();
            injectbutton = new Button();
            homebutton = new Button();
            settingsbutton = new Button();
            SuspendLayout();
            // 
            // closebutton
            // 
            closebutton.BackColor = Color.DimGray;
            closebutton.FlatAppearance.BorderSize = 0;
            closebutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            closebutton.FlatAppearance.MouseOverBackColor = Color.Red;
            closebutton.FlatStyle = FlatStyle.Flat;
            closebutton.Location = new Point(752, 0);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(48, 25);
            closebutton.TabIndex = 0;
            closebutton.Text = "close";
            closebutton.UseVisualStyleBackColor = false;
            closebutton.Click += button1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // minimizebutton
            // 
            minimizebutton.BackColor = Color.DimGray;
            minimizebutton.FlatAppearance.BorderSize = 0;
            minimizebutton.FlatStyle = FlatStyle.Flat;
            minimizebutton.Location = new Point(704, 0);
            minimizebutton.Name = "minimizebutton";
            minimizebutton.Size = new Size(48, 25);
            minimizebutton.TabIndex = 4;
            minimizebutton.Text = "minimize";
            minimizebutton.UseVisualStyleBackColor = false;
            minimizebutton.Click += button2_Click;
            // 
            // scripttext
            // 
            scripttext.BackColor = Color.FromArgb(40, 40, 40);
            scripttext.BorderStyle = BorderStyle.FixedSingle;
            scripttext.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scripttext.ForeColor = Color.White;
            scripttext.Location = new Point(54, 77);
            scripttext.Name = "scripttext";
            scripttext.Size = new Size(734, 279);
            scripttext.TabIndex = 5;
            scripttext.Text = "";
            // 
            // executescriptbutton
            // 
            executescriptbutton.BackColor = Color.FromArgb(45, 45, 45);
            executescriptbutton.FlatAppearance.BorderSize = 0;
            executescriptbutton.FlatStyle = FlatStyle.Flat;
            executescriptbutton.Location = new Point(54, 364);
            executescriptbutton.Name = "executescriptbutton";
            executescriptbutton.Size = new Size(44, 44);
            executescriptbutton.TabIndex = 6;
            executescriptbutton.Text = "execute";
            executescriptbutton.UseVisualStyleBackColor = false;
            executescriptbutton.Click += button3_Click;
            // 
            // savefilebutton
            // 
            savefilebutton.BackColor = Color.FromArgb(45, 45, 45);
            savefilebutton.FlatAppearance.BorderSize = 0;
            savefilebutton.FlatStyle = FlatStyle.Flat;
            savefilebutton.Location = new Point(104, 364);
            savefilebutton.Name = "savefilebutton";
            savefilebutton.Size = new Size(44, 44);
            savefilebutton.TabIndex = 8;
            savefilebutton.Text = "save";
            savefilebutton.UseVisualStyleBackColor = false;
            savefilebutton.Click += button4_Click;
            // 
            // openfilebutton
            // 
            openfilebutton.BackColor = Color.FromArgb(45, 45, 45);
            openfilebutton.FlatAppearance.BorderSize = 0;
            openfilebutton.FlatStyle = FlatStyle.Flat;
            openfilebutton.Location = new Point(154, 364);
            openfilebutton.Name = "openfilebutton";
            openfilebutton.Size = new Size(44, 44);
            openfilebutton.TabIndex = 9;
            openfilebutton.Text = "open";
            openfilebutton.UseVisualStyleBackColor = false;
            openfilebutton.Click += button5_Click;
            // 
            // injectbutton
            // 
            injectbutton.BackColor = Color.FromArgb(45, 45, 45);
            injectbutton.FlatAppearance.BorderSize = 0;
            injectbutton.FlatStyle = FlatStyle.Flat;
            injectbutton.Location = new Point(744, 364);
            injectbutton.Name = "injectbutton";
            injectbutton.Size = new Size(44, 44);
            injectbutton.TabIndex = 10;
            injectbutton.Text = "inject";
            injectbutton.UseVisualStyleBackColor = false;
            injectbutton.Click += button6_Click;
            // 
            // homebutton
            // 
            homebutton.BackColor = Color.FromArgb(45, 45, 45);
            homebutton.FlatAppearance.BorderSize = 0;
            homebutton.FlatStyle = FlatStyle.Flat;
            homebutton.Location = new Point(4, 35);
            homebutton.Name = "homebutton";
            homebutton.Size = new Size(44, 44);
            homebutton.TabIndex = 11;
            homebutton.Text = "home";
            homebutton.UseVisualStyleBackColor = false;
            homebutton.Click += button7_Click;
            // 
            // settingsbutton
            // 
            settingsbutton.BackColor = Color.FromArgb(45, 45, 45);
            settingsbutton.FlatAppearance.BorderSize = 0;
            settingsbutton.FlatStyle = FlatStyle.Flat;
            settingsbutton.Location = new Point(4, 85);
            settingsbutton.Name = "settingsbutton";
            settingsbutton.Size = new Size(44, 44);
            settingsbutton.TabIndex = 13;
            settingsbutton.Text = "settings";
            settingsbutton.UseVisualStyleBackColor = false;
            settingsbutton.Click += button9_Click;
            // 
            // lumeexecutor
            // 
            AccessibleName = "lume executor";
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(800, 420);
            Controls.Add(settingsbutton);
            Controls.Add(homebutton);
            Controls.Add(injectbutton);
            Controls.Add(openfilebutton);
            Controls.Add(savefilebutton);
            Controls.Add(executescriptbutton);
            Controls.Add(scripttext);
            Controls.Add(minimizebutton);
            Controls.Add(closebutton);
            Controls.Add(toolStrip1);
            Font = new Font("Georgia", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "lumeexecutor";
            Text = "lume executor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closebutton;
        private ToolStrip toolStrip1;
        private Button minimizebutton;
        private RichTextBox scripttext;
        private Button executescriptbutton;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button savefilebutton;
        private Button openfilebutton;
        private Button injectbutton;
        private Button homebutton;
        private Button settingsbutton;
    }
}
