using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Judger {
    public partial class LoaderPage : UserControl {
        public LoaderPage() {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e) {

        }

        private void btnExitProgram_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
