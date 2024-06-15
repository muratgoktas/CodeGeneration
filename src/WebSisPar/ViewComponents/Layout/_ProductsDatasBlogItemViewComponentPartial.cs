using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebSisPar.Dtos.ProductDtos;

namespace WebSisPar.ViewComponents.Layout
{
    public class _ProductsDatasBlogItemViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductsDatasBlogItemViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient(); //ToDo: Client serverdan istekte bulunacak
            //ToDO: Canlılya taşıdığımızda bu api adresi revize edilmesi lazım
            //ToDO: Aşağıdaki adresi sagger UI dan aldık.
            var responseMessage = await client.GetAsync("https://localhost:44334/api/Products/ProducListWithCategory");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
