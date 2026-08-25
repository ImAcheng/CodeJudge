namespace Judger {
    partial class LoaderPage {
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
            label1 = new Label();
            btnExitProgram = new Button();
            label2 = new Label();
            panel1 = new Panel();
            btnLoadFile = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(0, 200);
            label1.Name = "label1";
            label1.Size = new Size(850, 50);
            label1.TabIndex = 0;
            label1.Text = "Code Judge 程式碼評分系統";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExitProgram
            // 
            btnExitProgram.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExitProgram.BackColor = Color.White;
            btnExitProgram.FlatStyle = FlatStyle.Flat;
            btnExitProgram.Location = new Point(713, 10);
            btnExitProgram.Name = "btnExitProgram";
            btnExitProgram.Size = new Size(128, 40);
            btnExitProgram.TabIndex = 1;
            btnExitProgram.Text = "離開";
            btnExitProgram.UseVisualStyleBackColor = false;
            btnExitProgram.Click += btnExitProgram_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(0, 250);
            label2.Name = "label2";
            label2.Size = new Size(850, 50);
            label2.TabIndex = 2;
            label2.Text = "若要開始測驗 請讀取符合格式的題目檔案";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(btnLoadFile);
            panel1.Controls.Add(btnExitProgram);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 491);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 59);
            panel1.TabIndex = 3;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLoadFile.BackColor = Color.White;
            btnLoadFile.FlatStyle = FlatStyle.Flat;
            btnLoadFile.Location = new Point(579, 10);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(128, 40);
            btnLoadFile.TabIndex = 2;
            btnLoadFile.Text = "讀取題目檔案";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // LoaderPage
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoaderPage";
            Size = new Size(850, 550);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnExitProgram;
        private Label label2;
        private Panel panel1;
        private Button btnLoadFile;
    }
}
