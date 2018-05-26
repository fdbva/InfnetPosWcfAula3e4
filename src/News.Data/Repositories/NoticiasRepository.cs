using News.DomainModel.Aggregations.NoticiaAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Repositories
{
    public class NoticiasRepository
    {
        //Pseudo base de dados (Volátil)
        private static List<Noticia> _noticias = new List<Noticia>();

        public Noticia Add(Noticia noticia)
        {
            _noticias.Add(noticia);
            return Get(noticia.Id);
        }

        public void Update(Noticia noticia)
        {
            Delete(noticia.Id);
            Add(noticia);
        }

        public Noticia Get(Guid id)
        {
            return _noticias.Find(x => x.Id == id);
        }

        public IEnumerable<Noticia> GetAll()
        {
            return _noticias;
        }

        public void Delete(Guid id)
        {
            _noticias.Remove(Get(id));
        }
    }
}
