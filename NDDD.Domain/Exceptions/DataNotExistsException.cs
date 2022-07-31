namespace NDDD.Domain.Exceptions
{
    public sealed class DataNotExistsException : ExceptionBase
    {
        public DataNotExistsException() : base("データがありません")
        {

        }

        public override ExceptionKind Kind => ExceptionKind.Info;
    }
}
