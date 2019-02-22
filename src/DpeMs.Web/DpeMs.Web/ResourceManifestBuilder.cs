using OrchardCore.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DpeMs.Web
{
    public class ResourceManifestBuilder : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest
               .DefineStyle("bootstrap")
               .SetUrl("/OrchardCore.Resources/Styles/bootstrap.min.css", "/OrchardCore.Resources/Styles/bootstrap.css")
               .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css", "https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.css")
               .SetCdnIntegrity("sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO", "sha384-2QMA5oZ3MEXJddkHyZE/e/C1bd30ZUPdzqHrsaHMP3aGDbPA9yh77XDHXC9Imxw+")
               .SetVersion("4.1.3")
               ;

            manifest
                .DefineStyle("font-awesome")
                .SetUrl("/OrchardCore.Resources/Styles/font-awesome.min.css", "/OrchardCore.Resources/Styles/font-awesome.css")
                .SetCdn("https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css", "https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.css")
                .SetCdnIntegrity("sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN", "sha384-FckWOBo7yuyMS7In0aXZ0aoVvnInlnFMwCv77x9sZpFgOonQgnBj1uLwenWVtsEj")
                .SetVersion("4.7.0")
                ;

            manifest
                .DefineStyle("font-awesome")
                .SetCdn("https://use.fontawesome.com/releases/v5.2.0/css/all.css")
                .SetCdnIntegrity("sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ")
                .SetVersion("5.2.0")
                ;

            manifest
                .DefineScript("font-awesome")
                .SetCdn("https://use.fontawesome.com/releases/v5.2.0/js/all.js")
                .SetCdnIntegrity("sha384-4oV5EgaV02iISL2ban6c/RmotsABqE4yZxZLcYMAdG7FAPsyHYAPpywE9PJo+Khy")
                .SetVersion("5.2.0")
                ;

            manifest
                .DefineScript("font-awesome-v4-shims")
                .SetCdn("https://use.fontawesome.com/releases/v5.2.0/js/v4-shims.js")
                .SetCdnIntegrity("sha384-rn4uxZDX7xwNq5bkqSbpSQ3s4tK9evZrXAO1Gv9WTZK4p1+NFsJvOQmkos19ebn2")
                .SetVersion("5.2.0")
                ;
        }
    }
}
