namespace Judger {
    public class ProblemSet {
        public string ExamName { get; set; } = "Test";
        public Int64 ExamTime { get; set; } = 30 * 60 * 60;     // Unit: seconds
        public List<ProblemDetail> Problems { get; set; }
    }

    public class ProblemDetail {
        public string? ProblemTitle { get; set; }
        public string? ProblemContent { get; set; }
        public List<InputOutputSet>? ExampleIO { get; set; }
        public List<InputOutputSet>? FormalIO { get; set; }

        public ProblemDetail() {
            if (string.IsNullOrWhiteSpace(ProblemTitle)) {
                throw new ProblemTitleIsEmpty();
            }

            if (string.IsNullOrWhiteSpace(ProblemContent)) {
                throw new ProblemContentIsEmpty();
            }

            if (ExampleIO == null || ExampleIO?.Count == 0) {
                throw new ExampleIOIsEmpty();
            }

            if (FormalIO == null || FormalIO?.Count == 0) {
                throw new FormalIOIsEmpty();
            }
        }
    }

    public class InputOutputSet {
        public string? Input { get; set; }
        public string? Output { get; set; }
    }

    public class ProblemTitleIsEmpty : Exception { }
    public class ProblemContentIsEmpty : Exception { }
    public class ExampleIOIsEmpty : Exception { }
    public class FormalIOIsEmpty : Exception { }
}
