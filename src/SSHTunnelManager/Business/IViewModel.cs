namespace SSHTunnelManager.Business
{
    public interface IViewModel<TModel> where TModel : class
    {
        TModel Model { get; set; }
    }
}