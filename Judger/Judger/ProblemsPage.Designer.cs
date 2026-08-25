namespace Judger {
    partial class ProblemsPage {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            cbProblemList = new ComboBox();
            btnNext = new Button();
            btnPrevious = new Button();
            panelMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbProblemList);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPrevious);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 35);
            panel1.TabIndex = 0;
            // 
            // cbProblemList
            // 
            cbProblemList.Anchor = AnchorStyles.Right;
            cbProblemList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProblemList.FormattingEnabled = true;
            cbProblemList.Location = new Point(662, 4);
            cbProblemList.Name = "cbProblemList";
            cbProblemList.Size = new Size(185, 28);
            cbProblemList.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Dock = DockStyle.Left;
            btnNext.FlatStyle = FlatStyle.System;
            btnNext.Location = new Point(75, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 35);
            btnNext.TabIndex = 1;
            btnNext.Text = "→";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Dock = DockStyle.Left;
            btnPrevious.FlatStyle = FlatStyle.System;
            btnPrevious.Location = new Point(0, 0);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 35);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "←";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 35);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(850, 515);
            panelMain.TabIndex = 1;
            // 
            // ProblemsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ProblemsPage";
            Size = new Size(850, 550);
            Load += ProblemsPage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPrevious;
        private ComboBox cbProblemList;
        private Button btnNext;
        private Panel panelMain;
    }
}
