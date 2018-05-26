using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using News.Data.Repositories;
using News.DomainModel.Aggregations.NoticiaAggregate;

namespace News.DomainService
{
    public class PublicacaoService
    {
        private readonly NoticiasRepository _noticiasRepository;

        public PublicacaoService(NoticiasRepository noticiasRepository)
        {
            _noticiasRepository = noticiasRepository;
        }

        public bool PublicarNoticia(Noticia noticia)
        {
            return _noticiasRepository.Add(noticia) != null;
        }

        public IEnumerable<Noticia> ObterNoticiasPublicadas()
        {
            return _noticiasRepository.GetAll();
        }
    }
}
