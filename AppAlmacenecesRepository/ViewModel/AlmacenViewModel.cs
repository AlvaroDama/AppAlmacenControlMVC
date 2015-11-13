using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppAlmacenecesRepository.Model;
using BaseRepository.ViewModel;

namespace AppAlmacenecesRepository.ViewModel
{
    public class AlmacenViewModel : IViewModel<Almacen>
    {
        [Required(ErrorMessage = "La ubicación del almacén es obligatoria.")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El Código Postal es obligatorio.")]
        [DisplayName("Código Postal")]
        [RegularExpression("[0-9]{5}", ErrorMessage = "El CP consta de 5 caracteres.")]
        public int CPostal { get; set; }
        public int ID { get; set; }

        public Almacen ToBaseDatos()
        {
            return new Almacen()
            {
                Ciudad = this.Ciudad,
                CPostal = this.CPostal,
                ID = this.ID
            };
        }

        public void FromBaseDatos(Almacen modelo)
        {
            this.ID = modelo.ID;
            this.Ciudad = modelo.Ciudad;
            this.CPostal = modelo.CPostal;
        }

        public void UpdateBaseDatos(Almacen modelo)
        {
            modelo.ID = this.ID;
            modelo.CPostal = this.CPostal;
            modelo.Ciudad = this.Ciudad;
        }

        public object[] GetKeys()
        {
            return new[] { (object)this.ID };
        }
    }
}
