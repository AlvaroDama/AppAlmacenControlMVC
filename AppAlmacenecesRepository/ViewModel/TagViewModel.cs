using AppAlmacenecesRepository.Model;
using BaseRepository.ViewModel;

namespace AppAlmacenecesRepository.ViewModel
{
    public class TagViewModel:IViewModel<Tag>
    {
        public string Texto { get; set; }
        public int ID { get; set; }

        public Tag ToBaseDatos()
        {
            return new Tag()
            {
                ID = this.ID,
                Texto = this.Texto
            };
        }

        public void FromBaseDatos(Tag modelo)
        {
            this.ID = modelo.ID;
            this.Texto = modelo.Texto;
        }

        public void UpdateBaseDatos(Tag modelo)
        {
            modelo.ID = this.ID;
            modelo.Texto = this.Texto;
        }

        public object[] GetKeys()
        {
            return new[] {(object) this.ID};
        }
    }
}
