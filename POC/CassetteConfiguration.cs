using Cassette;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace POC
{
    /// <summary>
    /// Configures the Cassette asset bundles for the web application.
    /// </summary>
    public class CassetteBundleConfiguration : IConfiguration<BundleCollection>
    {
        public void Configure(BundleCollection bundles)
        {
            // Please read http://getcassette.net/documentation/configuration

            // We let Sass handle concatination
            bundles.Add<StylesheetBundle>("Styles/main.css", b => b.EmbedImages());
            bundles.Add<StylesheetBundle>("Styles/ie.css");

            bundles.AddUrlWithAlias("http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js","~/jquery");

            bundles.Add<ScriptBundle>("Scripts",b=>b.AddReference("~/jquery"));

        }
    }
}