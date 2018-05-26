using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using News.Data.Repositories;
using News.DomainModel.Aggregations.NoticiaAggregate;

namespace News.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PublicacaoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PublicacaoService.svc or PublicacaoService.svc.cs at the Solution Explorer and start debugging.
    public class PublicacaoService : IPublicacaoService
    {
        public bool PublicarNoticia(Noticia noticia)
        {
            var publicacaoService = new DomainService
                .PublicacaoService(new NoticiasRepository());
            return publicacaoService.PublicarNoticia(noticia);
        }

        public IEnumerable<Noticia> ObterNoticiasPublicadas()
        {
            var publicacaoService = new DomainService
                .PublicacaoService(new NoticiasRepository());
            return publicacaoService.ObterNoticiasPublicadas();
        }
    }
}
