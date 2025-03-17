using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Elastic.Clients.Elasticsearch;
using Elastic.Transport;

namespace BooksProject
{
    internal static class Program
    {
        public static ElasticsearchClientSettings ElasticSettings;

        [STAThread]
        static void Main()
        {
            ElasticSettings = new ElasticsearchClientSettings(new Uri("http://localhost:9200"))
                .Authentication(new BasicAuthentication("elastic", "Saeed123456"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSearch());
        }
    }
}
