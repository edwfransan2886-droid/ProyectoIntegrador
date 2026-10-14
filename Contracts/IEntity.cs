namespace EcoFacility.Contracts
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
