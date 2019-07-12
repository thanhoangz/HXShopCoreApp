namespace HXShopCoreApp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerIdP { get; set; }
    }
}
