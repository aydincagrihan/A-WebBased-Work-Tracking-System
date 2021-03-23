using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.ToDo.DTO.DTOs.GorevDtos;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web.ElasticSearch
{
    public class ElasticSearch
    {
        private static readonly ConnectionSettings connSettings = new ConnectionSettings(new Uri("http://localhost:9200/"))
                       .DefaultIndex("change_history");
        //.DefaultMappingFor(m => m                          // burayı değiştirdin
        // .Add(typeof(ChangeLog), "change_history"));
        private static readonly ElasticClient elasticClient = new ElasticClient(connSettings);


        public static void CheckExistsAndInsert(GorevAddDto gorevAdd)
        {
            elasticClient.Indices.DeleteAsync("gorev");           


            if (!elasticClient.Indices.Exists("gorev").Exists)  
            {
                var indexSettings = new IndexSettings();
                indexSettings.NumberOfReplicas = 1;
                indexSettings.NumberOfShards = 3;


                var createIndexDescriptor = new CreateIndexDescriptor("change_history")
               .Mappings(ms => ms
                               .Map<GorevAddDto>(m => m.AutoMap())
                        )
                .InitializeUsing(new IndexState() { Settings = indexSettings })
                .Aliases(a => a.Alias("change_log"));

                var response = elasticClient.Indices.Create(createIndexDescriptor);  // değiştirdin
            }
            elasticClient.Index<GorevAddDto>(gorevAdd, idx => idx.Index("change_history"));
        }
    }
}
