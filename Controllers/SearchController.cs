using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using BooksProject.Models;
using DevExpress.Utils.Url;
using DevExpress.XtraReports.Templates;
using Elastic.Clients.Elasticsearch;
using Elastic.Clients.Elasticsearch.Nodes;
using Elastic.Clients.Elasticsearch.QueryDsl;
using Elastic.Transport.Extensions;

namespace BooksProject.Controllers
{
    public class SearchController
    {

        private readonly ElasticsearchClient _client;
        public SearchController()
        {
            this._client = new ElasticsearchClient(Program.ElasticSettings);
        }

        public async Task<List<string>> GetPublishPlaces()
        {
            try
            {
                var response = await this._client.SearchAsync<BookViewModel>(s => s
                    .Index("books")
                    .Size(0)
                    .Aggregations(aggregations => aggregations.Add("PublishPlaces", ag => ag
                        .Terms(term => term.Field(f => f.Publish_place).Size(100)))
                    )
                );

                if (response.IsValidResponse)
                    return response.Aggregations!.GetStringTerms("PublishPlaces")!.Buckets.Select(s => s.Key.ToString()).ToList();

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<BookViewModel>> GetBooks(SearchViewModel SearchParameters)
        {
            try
            {
                var response = await this._client.SearchAsync<BookViewModel>(s => s
                    .Index("books")
                    .Size(10000)
                    .Query(SearchParameters.IsNormalSearch ? BuildQuery_Normal(SearchParameters) : BuildQuery_Advanced(SearchParameters)));

                if (response.IsValidResponse)
                    return response.Documents.ToList();

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private Action<QueryDescriptor<BookViewModel>> BuildQuery_Normal(SearchViewModel SearchParameters)
        {
            var musts = new List<Action<QueryDescriptor<BookViewModel>>>();
            var shoulds = new List<Action<QueryDescriptor<BookViewModel>>>();

            if (!string.IsNullOrWhiteSpace(SearchParameters.FullSearch))
            {
                musts.Add(must => must.MultiMatch(m => m.Query(SearchParameters.FullSearch).Fields("title, author")));

                if (SearchParameters.Priority == PriorityEnum.Title)
                    shoulds.Add(sh => sh.MatchPhrase(m => m.Field(f => f.Title).Query(SearchParameters.FullSearch)));
                else if (SearchParameters.Priority == PriorityEnum.Author)
                    shoulds.Add(sh => sh.MatchPhrase(m => m.Field(f => f.Author).Query(SearchParameters.FullSearch)));
            }

            return query => query.Bool(bo => bo.Must(musts.ToArray()).Should(shoulds.ToArray()));
        }
        private Action<QueryDescriptor<BookViewModel>> BuildQuery_Advanced(SearchViewModel SearchParameters)
        {
            var musts = new List<Action<QueryDescriptor<BookViewModel>>>();
            var filters = new List<Action<QueryDescriptor<BookViewModel>>>();
            var shoulds = new List<Action<QueryDescriptor<BookViewModel>>>();

            if (SearchParameters.Accuracy == AccuracyEnum.MatchPhrase)
            {
                if (!string.IsNullOrWhiteSpace(SearchParameters.Title))
                    musts.Add(must => must.MatchPhrase(m => m.Field(f => f.Title).Query(SearchParameters.Title)));

                if (!string.IsNullOrWhiteSpace(SearchParameters.Author))
                    musts.Add(must => must.MatchPhrase(m => m.Field(f => f.Author).Query(SearchParameters.Author)));

                if (!string.IsNullOrWhiteSpace(SearchParameters.Publisher))
                    musts.Add(must => must.MatchPhrase(m => m.Field(f => f.Publisher).Query(SearchParameters.Publisher)));
            }
            else if (SearchParameters.Accuracy == AccuracyEnum.Match)
            {
                if (!string.IsNullOrWhiteSpace(SearchParameters.Title))
                {
                    musts.Add(must => must.Match(m => m.Field(f => f.Title).Query(SearchParameters.Title)));
                    shoulds.Add(sh => sh.MatchPhrase(m => m.Field(f => f.Title).Query(SearchParameters.Title)));
                }

                if (!string.IsNullOrWhiteSpace(SearchParameters.Author))
                {
                    musts.Add(must => must.Match(m => m.Field(f => f.Author).Query(SearchParameters.Author)));
                    shoulds.Add(sh => sh.MatchPhrase(m => m.Field(f => f.Author).Query(SearchParameters.Author)));

                }

                if (!string.IsNullOrWhiteSpace(SearchParameters.Publisher))
                {
                    musts.Add(must => must.Match(m => m.Field(f => f.Publisher).Query(SearchParameters.Publisher)));
                    shoulds.Add(sh => sh.MatchPhrase(m => m.Field(f => f.Publisher).Query(SearchParameters.Publisher)));
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(SearchParameters.Title))
                {
                    musts.Add(must => must.Wildcard(w => w.Field(f => f.Title).Value("*" + SearchParameters.Title + "*")));
                    shoulds.Add(sh => sh.MatchPhrase(m => m.Field(f => f.Title).Query(SearchParameters.Title)));
                }

                if (!string.IsNullOrWhiteSpace(SearchParameters.Author))
                {
                    musts.Add(must => must.Wildcard(w => w.Field(f => f.Author).Value("*" + SearchParameters.Author + "*")));
                    shoulds.Add(sh => sh.MatchPhrase(m => m.Field(f => f.Author).Query(SearchParameters.Author)));
                }

                if (!string.IsNullOrWhiteSpace(SearchParameters.Publisher))
                {
                    musts.Add(must => must.Wildcard(w => w.Field(f => f.Publisher).Value("*" + SearchParameters.Publisher + "*")));
                    shoulds.Add(sh => sh.MatchPhrase(m => m.Field(f => f.Publisher).Query(SearchParameters.Publisher)));
                }
            }

            if (!string.IsNullOrWhiteSpace(SearchParameters.PublishPlace))
                filters.Add(filter => filter.Term(t => t.Field(f => f.Publish_place).Value(SearchParameters.PublishPlace)));

            if (!string.IsNullOrWhiteSpace(SearchParameters.PublishDateFrom) && !string.IsNullOrWhiteSpace(SearchParameters.PublishDateTo))
            {
                filters.Add(filter => filter.Range(r => r.DateRange(dr => dr.Field(f => f.Publish_date)
                    .Gte(SearchParameters.PublishDateFrom).Lte(SearchParameters.PublishDateTo))));
            }
            else if (!string.IsNullOrWhiteSpace(SearchParameters.PublishDateFrom))
            {
                filters.Add(filter => filter.Range(r => r.DateRange(dr => dr.Field(f => f.Publish_date)
                    .Gte(SearchParameters.PublishDateFrom))));
            }
            else if (!string.IsNullOrWhiteSpace(SearchParameters.PublishDateTo))
            {
                filters.Add(filter => filter.Range(r => r.DateRange(dr => dr.Field(f => f.Publish_date)
                    .Lte(SearchParameters.PublishDateTo))));
            }

            return query => query.Bool(bo => bo.Must(musts.ToArray()).Filter(filters.ToArray()).Should(shoulds.ToArray()));
        }

    }
}
