using InsitutoIsaccNewtonTutoriales.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsitutoIsaccNewtonTutoriales.Entities
{
    public class MediaType:IPrimaryProperties
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [Required]
        [Display(Name ="Ruta a la imagen")]
        public string ThumbnailImagePath { get; set; }

        [ForeignKey("MediaTypeId")]
        [Display(Name = "Elementos de la categoria")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

    }
}
