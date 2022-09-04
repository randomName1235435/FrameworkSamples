using System;
using System.Windows;

namespace WpfSample
{
    internal class SampleMultipleStylesWpf
    {
        public void ChangeStyle(string ressourceDictionaryName)
        {
            var path = "samplePath";

            //*notes: only works with complete independent ressource dictionaries, so use resmerger or something and dynamicResource in views/controls

            var ressources = new ResourceDictionary();
            ressources.Source = new Uri(@"Resources/Dictionaries/" + path, UriKind.Relative);

            Application.Current.Resources.Clear();
            Application.Current.Resources.Source = new Uri(@"Resources/Dictionaries/" + path, UriKind.Relative);
        }
    }
}