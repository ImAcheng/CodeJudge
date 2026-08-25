namespace Judger.Extention {
    /// <summary>
    ///     Message Box Presets
    /// </summary>
    public class JudgerMessageBox {
        public static void ShowInfo(string message) {
            MessageBox.Show(message, "Code Judge",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string message) {
            MessageBox.Show(message, "Code Judge",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ShowYesNo(string message) {
            return MessageBox.Show(message, "Code Judge",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
