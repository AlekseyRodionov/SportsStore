using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController: Controller
    {
        //Получаем данные из хранилища
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        //Передаем данные в стандартное представление 
        public ViewResult List() => View(repository.Products);
    }
}
