using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InsitutoIsaccNewtonTutoriales.Entities
{
    public class Content
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        [Display(Name ="Contenido HTML")]
        public string HTMLContent { get; set; }

        [Display(Name ="Link del video")]
        public string VideoLink { get; set; }

        //one to one relation
        [Display(Name = "Elemento de la categoria")]
        public CategoryItem CategoryItem { get; set; }

        [NotMapped]
        public int CatItemId { get; set; }

        [NotMapped]
        public int CategoryId { get; set; }
    }
}
