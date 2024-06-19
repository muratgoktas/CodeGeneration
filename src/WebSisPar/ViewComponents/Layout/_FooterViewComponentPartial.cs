using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebSisPar.Dtos.AboutDtos;

namespace WebSisPar.ViewComponents.Layout
{
    public class _FooterViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _FooterViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44334/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                /* ToDo: var responseMessage = await client.GetAsync("https://localhost:44334/api/Abouts");
                 * ToDo:Liste şeklinde seçilirse */
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultAboutDtos>>(jsonData);

                ViewBag.title = value.Select(x => x.Title).FirstOrDefault();
                ViewBag.subtitle = value.Select(x => x.Subtitle).FirstOrDefault();
                ViewBag.description = value.Select(x => x.Description).FirstOrDefault();
                ViewBag.pictureLink01 = value.Select(m => m.PictureLink01).FirstOrDefault();
                ViewBag.pictureLink02 = value.Select(m => m.PictureLink02).FirstOrDefault();
                ViewBag.pictureLink03 = value.Select(m => m.PictureLink03).FirstOrDefault();
                return View();
                /* ToDo: veri tabanında Id=3 olan data seti seçilirse 
                 * ToDo:  var responseMessage = await client.GetAsync("https://localhost:44334/api/Abouts/3");
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultAboutDtos>(jsonData);
                ViewBag.title = value.Title;
                ViewBag.subtitle = value.Subtitle;
                ViewBag.description = value.Description;
                ViewBag.pictureLink01 = value.PictureLink01;
                ViewBag.pictureLink02 = value.PictureLink02;
                ViewBag.pictureLink03 = value.PictureLink03;
                return View();*/
            }
            return View();
        }
    }
}
