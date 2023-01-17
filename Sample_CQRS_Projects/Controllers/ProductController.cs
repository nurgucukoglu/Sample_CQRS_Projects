using Microsoft.AspNetCore.Mvc;
using Sample_CQRS_Projects.CQRS.Commands.ProductCommands;
using Sample_CQRS_Projects.CQRS.Handlers.ProductHandlers;

namespace Sample_CQRS_Projects.Controllers
{
	public class ProductController : Controller
	{
		private readonly GetProductByAccounterQueryHandler _getProductByAccounterQueryHandler;
        private readonly GetProductByStorageQueryHandler _getProductByStorageQueryHandler;
        private readonly GetProductHumanResourcesByIDQueryHandler _getHumanResourcesByIDQueryHandler;
        private readonly GetProductAccounterByIDQueryHandler _getProductAccounterByIDQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        public ProductController(GetProductByAccounterQueryHandler getProductByAccounterQueryHandler, GetProductByStorageQueryHandler getProductByStorageQueryHandler, GetProductHumanResourcesByIDQueryHandler getHumanResourcesByIDQueryHandler, GetProductAccounterByIDQueryHandler getProductAccounterByIDQueryHandler, CreateProductCommandHandler createProductCommandHandler)
        {
            _getProductByAccounterQueryHandler = getProductByAccounterQueryHandler;
            _getProductByStorageQueryHandler = getProductByStorageQueryHandler;
            _getHumanResourcesByIDQueryHandler = getHumanResourcesByIDQueryHandler;
            _getProductAccounterByIDQueryHandler = getProductAccounterByIDQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
        }

        public IActionResult Index()
		{
			var values = _getProductByAccounterQueryHandler.Handle();
			return View(values);
		}

		public IActionResult StoragerIndex()
		{
            var values = _getProductByStorageQueryHandler.Handle();
            return View(values);
        }

        public IActionResult GetHumanResourcesIndex(int id)
        {
            var values = _getHumanResourcesByIDQueryHandler.Handle(new CQRS.Queries.ProductQueries.GetProductHumanResourceByIDQuery(id));//id'yi burada kullanabilmek için constructor içinde yazdık
            return View(values);
        }

        //id'ye göre muhaebecinin verileri getirilsin.
        public IActionResult GetAccounterIndexByID(int id)
        {
            var values = _getProductAccounterByIDQueryHandler.Handle(new CQRS.Queries.ProductQueries.GetProductAccounterByIDQuery(id));//id'yi burada kullanabilmek için constructor içinde yazdık
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
