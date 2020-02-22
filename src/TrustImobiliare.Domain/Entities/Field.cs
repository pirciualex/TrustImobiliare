namespace TrustImobiliare.Domain.Entities
{
    public class Field : Property
    {
        public Field()
        {
            TypeId = 1;
        }

        public new int TypeId { get; }
    }
}