namespace Judger {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        public static FormMain instance;
        private UserControl currentPage;
        public LoaderPage loaderPage = new LoaderPage();
        public ProblemsPage problemPage;

        private void FormMain_Load(object sender, EventArgs e) {
            instance = this;
            SetPage(loaderPage);
        }

        #region functions
        /// <summary>
        ///     Set the displaying page and dispose the old one.
        /// </summary>
        /// <param name="target"></param>
        public void SetPage(UserControl target) {
            currentPage?.Dispose();
            target.Parent = panelMain;
            target.Dock = DockStyle.Fill;
            currentPage = target;
        }

        /// <summary>
        ///     Initialize a new Problems Page.
        /// </summary>
        /// <param name="problem"></param>
        public void SetProblems(ProblemSet problem) {
            problemPage = new ProblemsPage(problem);
            currentPage?.Dispose();
            SetPage(problemPage);
        }
        #endregion
    }
}
