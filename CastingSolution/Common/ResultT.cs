namespace CastingSolution.Common
{
    public sealed class Result<T> : Result
    {
        private readonly T _value;
        public T Value =>
            IsSuccess ? _value :
            throw new InvalidOperationException("Não é possível acessar Value em um resultado de falha.");

        private Result(bool isSuccess, T value, Error error)
            : base(isSuccess, error)
        {
            _value = value;
        }

        public static Result<T> Success(T value)
        {
            ArgumentNullException.ThrowIfNull(value);

            return new Result<T>(true, value, Error.None);
        }

        public new static Result<T> Failure(Error error)
        {
            return new Result<T>(false, default, error);
        }
    }
}
