namespace CastingSolution.Common
{
    public class Result
    {
        public bool IsSuccess { get; }
        public Error? Error { get; }

        protected Result(bool isSuccess, Error? error)
        {
            ArgumentNullException.ThrowIfNull(error);

            if (isSuccess && error != Error.None)
            {
                throw new InvalidOperationException(
                    "Um resultado de sucesso não pode conter um erro.");
            }

            if (!isSuccess &&
                (error == Error.None ||
                 string.IsNullOrWhiteSpace(error.Code) ||
                 string.IsNullOrWhiteSpace(error.Message)))
            {
                throw new InvalidOperationException(
                    "Uma falha precisa de código e mensagem.");
            }

            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result Success()
        {
            return new Result(true, Error.None);
        }

        public static Result Failure(Error error)
        {
            return new Result(false, error);
        }
    }
}
