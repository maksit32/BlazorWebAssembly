namespace BlazorHm1.Models
{
    public interface ICatalog
    {
        List<Product> GetCatalog();
        void AddItemToCatalog(Product product);
    }
}