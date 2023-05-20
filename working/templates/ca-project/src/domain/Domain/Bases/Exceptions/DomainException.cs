namespace Domain.Bases.Exceptions
{
    internal abstract class DomainException : Exception
    {
        protected DomainException(string message) : base(message) { }
    }
}
