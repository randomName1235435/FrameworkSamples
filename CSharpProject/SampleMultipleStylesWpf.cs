using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class SampleMultipleStylesWpf
    {
        public void ChangeStyle(string ressourceDictionaryName) {

            //*notes: only works with complete independent ressource dictionaries, so use resmerger or something and dynamicResource in views/controls
             
            var ressources = new ResourceDictionary();
            ressources.Source = new Uri(@"Resources/Dictionaries/" + path, UriKind.Relative);

            Application.Current.Resources.Clear();
            Application.Current.Resources.Source = new Uri(@"Resources/Dictionaries/" + path, UriKind.Relative);
        }
    }
}
