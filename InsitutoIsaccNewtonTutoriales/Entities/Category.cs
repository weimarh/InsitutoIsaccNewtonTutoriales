using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsitutoIsaccNewtonTutoriales.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Titulo")]
        [StringLength(200, MinimumLength =2)]
        public string Title { get; set; }

        [Display(Name ="Descripcion")]
        public string Description { get; set; }

        [Required]
        [Display(Name ="Ruta a la imagen")]
        public string ThumbnailImagePath { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        [ForeignKey("CategoryId")]
        public ICollection<UserCategory> UserCategory { get; set; }


    }
}
