using InsitutoIsaccNewtonTutoriales.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InsitutoIsaccNewtonTutoriales.Data
{
    //Se crea esta clase para aumentar columnas en la tabla AspUsersTable
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Address1 { get; set; }

        [StringLength(100)]
        public string Address2 { get; set; }

        [ForeignKey("UserId")]
        public ICollection<UserCategory> UserCategory { get; set; }

    }
    //Se usa generics para integrar nuestro identityUser con nuestra base de datos
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryItem> CategoryItem { get; set; }
        public DbSet<MediaType> MediaType { get; set; }
        public DbSet<UserCategory> UserCategory { get; set; }
        public DbSet<Content> Content { get; set; }

    }
}
