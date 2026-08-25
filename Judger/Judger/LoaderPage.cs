using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Judger.Extention;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Judger {
    public partial class LoaderPage : UserControl {
        private static IDeserializer YamlDeserializer;

        public LoaderPage() {
            InitializeComponent();
            YamlDeserializer = new DeserializerBuilder()
                                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                                .Build();
        }

        private void btnLoadFile_Click(object sender, EventArgs e) {
            using var ofd = new OpenFileDialog() {
                Title = "選擇指定的題目檔",
                Filter = "Problem File|*.yml|All File|*.*"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            string fp = ofd.FileName;
            if (string.IsNullOrWhiteSpace(fp)) {
                JudgerMessageBox.ShowInfo("指定的檔案路徑為空");
                return;
            }

            if(!File.Exists(fp)) {
                JudgerMessageBox.ShowInfo("指定的檔案路徑不存在");
                return;
            }

            string yamlString = File.ReadAllText(fp);

            if (string.IsNullOrWhiteSpace(yamlString)) {
                JudgerMessageBox.ShowError("目標檔案內容為空");
                return;
            }

            ProblemSet problems;

            try {
                problems = YamlDeserializer.Deserialize<ProblemSet>(yamlString);

                if (string.IsNullOrWhiteSpace(problems.ExamName)) {
                    JudgerMessageBox.ShowInfo("指定題目檔案標題資料不存在，將使用預設名稱。");
                }

                if (string.IsNullOrWhiteSpace(problems.ExamName)) {
                    JudgerMessageBox.ShowInfo("指定題目檔案測驗時間資料不存在，將使用預設名稱。");
                }
            }
            catch (Exception ex) {
                JudgerMessageBox.ShowError($"指定題目檔案已經毀損，且無法辨別錯誤內容。\nException: {ex.Message}");
                return;
            }

            FormMain.instance.SetProblems(problems);
        }

        private void btnExitProgram_Click(object sender, EventArgs e) {
            if (!JudgerMessageBox.ShowYesNo("是否要關閉本軟體?")) return;
            Application.Exit();
        }
    }
}
