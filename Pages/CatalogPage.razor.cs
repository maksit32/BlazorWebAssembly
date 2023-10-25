using BlazorHm1.Models;
using Microsoft.AspNetCore.Components;

//логика для CatalogPage.razor (взято из @code{})

namespace AmazingShop.Pages
{
    public partial class CatalogPage
    {
		public int _id = 3; //костыль
		private List<Product> _collection;

		protected override void OnInitialized()
		{
			base.OnInitialized();
			_collection = Catalog.GetCatalog();
		}
	}
}
