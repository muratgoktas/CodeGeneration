using Microsoft.Extensions.Localization;
using System.Reflection;

namespace WebSisPar.Services
{
    public class LanguageService
    {
        public class SharedResource
        {

        }

        private readonly IStringLocalizer _localizer;

        public LanguageService(IStringLocalizerFactory factory)
        {
            var type = typeof(SharedResource);
            var assamblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create(nameof(SharedResource), assamblyName.Name);// yerini ve konumunu göstrir.

        }
        public LocalizedString GetKey(string key)
        {
            return _localizer[key];
        }
    }
}
