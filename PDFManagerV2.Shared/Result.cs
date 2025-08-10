namespace PDFManagerV2.Shared
{
    public class Result<T> : Result
    {
        public T Value { get; private set; }

        private Result(bool isSuccess,T value, List<string> errors) : base(isSuccess, errors)
        {
            Value = value;
        }
        public static Result<T> Success(T value) => new Result<T>(true, value, new List<string>());
        public static new Result<T> Failure(List<string> errors) => new Result<T>(false, default(T), errors);
        public static Result<T> Failure(string error) => new Result<T>(false, default(T), new List<string> { error });

    }
    public class Result
    {
        public bool IsSuccess { get; protected set; }
        public bool IsFailure => !IsSuccess;
        public IReadOnlyList<string> Errors { get; protected set; }
        protected Result(bool isSuccess, List<string> errors)
        {
            IsSuccess = isSuccess;
            Errors = errors ?? new List<string>();
        }

        public static Result Success() => new Result(true, new List<string>());
        public static Result Failure(List<string> errors) => new Result(false, errors);
        public static Result Failure(string error) => new Result(false, new List<string> { error });

    }
}