namespace CastingSolution.Common
{
    public sealed record Error(string Code, string Message)
    {
        public static readonly Error None = new("", "");
    }
}
