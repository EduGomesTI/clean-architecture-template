namespace Domain.Bases.Entities
{
    public abstract class BaseEntity<TId>
    {

        #region Properties

        public TId Id { get; private set; }

        public DateTime CreateDate { get; private set; }

        public List<string> Messages { get; private set; }

        #endregion

        #region Constructors

        public BaseEntity(TId id)
        {
            Id = id;
            CreateDate = DateTime.UtcNow;
            Messages = new List<string>();
        }

        #endregion

        #region Methods

        public void AddMessage(string message) => Messages.Add(message);
        public void AddMessages(IEnumerable<string> messages) => Messages.AddRange(messages);

        #endregion
    }
}
