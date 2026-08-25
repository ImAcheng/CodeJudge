using Judger.Extention;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Judger {
    public partial class ProblemsPage : UserControl {
        #region default data
        /// <summary>
        ///     Represents the default content when the data is null or empty.
        /// </summary>
        private static readonly string[] _EmptyComboBoxContent = { "(沒有內容)" };
        #endregion

        private bool _DataFailedFlag = false;
        private readonly ProblemSet _Problem;
        private readonly List<ProblemDisplayer> _Pages;

        public ProblemsPage(ProblemSet problem) {
            InitializeComponent();
            _Problem = problem;

            if (problem.Problems != null && problem.Problems.Count != 0) {
                _Pages = _Problem.Problems.Select(x => new ProblemDisplayer(x)).ToList();
            }
            else _DataFailedFlag = true;
        }

        private void ProblemsPage_Load(object sender, EventArgs e) {
            if (_DataFailedFlag) {
                JudgerMessageBox.ShowError("題目內容為空或無法正常讀取。");
            }

            _SetPageContent();
        }

        #region functions
        private void _SetPageContent() {
            var titleList = _DataFailedFlag ? _EmptyComboBoxContent : 
                _Problem.Problems.Select(x => x.ProblemTitle).ToArray();
            cbProblemList.Items.AddRange(titleList);

            cbProblemList.SelectedIndex = 0;

            if (_DataFailedFlag) {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
            }
        }
        #endregion
    }
}
