namespace Odws.Utilities
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}