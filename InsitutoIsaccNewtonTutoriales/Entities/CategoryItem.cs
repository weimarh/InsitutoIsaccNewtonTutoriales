using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsitutoIsaccNewtonTutoriales.Entities
{
    public class CategoryItem
    {
        //Inicia la aplicacion con la fecha con la fecha actual
        private DateTime _releaseDate = DateTime.MinValue;
        public int Id { get; set; }

        [Required]
        [Display(Name ="Titulo")]
        [StringLength(200, MinimumLength =2)]
        public string Title { get; set; }

        [Display(Name ="Descripcion")]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Por favor seleccione un elemento valido de la lista")]
        [Display(Name ="Tipo de media")]
        public int MediaTypeId { get; set; }
        
        [NotMapped]
        public ICollection<SelectListItem> MediaTypes { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name ="Fecha de lanzamiento")]
        public DateTime DateTimeItemReleased 
        { 
            get
            {
                return (_releaseDate == DateTime.MinValue) ? DateTime.Now : _releaseDate;
            }
            set
            {
                _releaseDate = value;
            }
        }

        [NotMapped]
        public int ContentId { get; set; }

    }
}
