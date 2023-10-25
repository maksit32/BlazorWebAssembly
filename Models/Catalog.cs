namespace BlazorHm1.Models
{
    public class Catalog : ICatalog
    {
        private List<Product> _catalog;

        public Catalog()
        {
            _catalog = new List<Product>() { new Product(250, "Машина", "очень хорошая машина", "https://avatars.mds.yandex.net/get-autoru-reviews/1387785/Qa1HGuJ9G1w9NQ6v2BXCMLQuo17fmEPKr/1200x900", "https://ru.wikipedia.org/wiki/%D0%9C%D0%B0%D1%88%D0%B8%D0%BD%D0%B0", AmazingShop.Models.CategoriesProduct.Car),
                                             new Product(350, "Вертолет", "весьма неплохой вертолет", "https://upload.wikimedia.org/wikipedia/commons/e/e0/Vertical-T_Mil_Mi-8.jpg", "https://ru.wikipedia.org/wiki/%D0%92%D0%B5%D1%80%D1%82%D0%BE%D0%BB%D1%91%D1%82", AmazingShop.Models.CategoriesProduct.Helicopters),
                                             new Product(220, "Мотоцикл", "быстрый новый мотоцикл", "https://atvarmor.ru/wp-content/uploads/2020/10/8b8fe188-7e07-4102-b210-2f26d353e022_bse_z7_green_blast_new_1.png", "https://ru.wikipedia.org/wiki/%D0%9C%D0%BE%D1%82%D0%BE%D1%86%D0%B8%D0%BA%D0%BB", AmazingShop.Models.CategoriesProduct.Motorcycle)};
        }

        public Catalog(List<Product> catalog)
        {
            _catalog = catalog;
        }

        public List<Product> GetCatalog()
        {
            return _catalog;
        }

        public void AddItemToCatalog(Product product)
        {
            _catalog.Add(product);
        }
    }
}
