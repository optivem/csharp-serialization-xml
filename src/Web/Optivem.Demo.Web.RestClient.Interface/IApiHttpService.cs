namespace Optivem.Demo.Web.RestClient.Interface
{
    public interface IApiHttpService
    {
        ICustomerHttpService Customers { get; }

        IOrderHttpService Orders { get; }

        IProductHttpService Products { get; }
    }
}