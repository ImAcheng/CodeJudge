using System.ComponentModel.DataAnnotations;

namespace Judger {
    public class ProblemSet {
        public string ExamName { get; set; } = "Test";
        public Int64 ExamTime { get; set; } = 30 * 60;     // Unit: seconds
        public List<ProblemDetail> Problems { get; set; } = new List<ProblemDetail>();
    }

    public class ProblemDetail {
        public string ProblemTitle { get; set; } = "(沒有標題)";
        public string ProblemContent { get; set; } = "(沒有內容)";
        public List<InputOutputSet>? ExampleIO { get; set; }
        public List<InputOutputSet>? FormalIO { get; set; }
    }

    public class InputOutputSet {
        public string? Input { get; set; }
        public string? Output { get; set; }
    }
}
