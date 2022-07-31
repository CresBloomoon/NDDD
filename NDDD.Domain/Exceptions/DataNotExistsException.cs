namespace NDDD.Domain.Exceptions
{
    /// <summary>
    /// データなし例外
    /// </summary>
    public sealed class DataNotExistsException : ExceptionBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DataNotExistsException() : base("データがありません")
        {

        }

        /// <summary>
        /// 区分
        /// </summary>
        public override ExceptionKind Kind => ExceptionKind.Info;
    }
}
