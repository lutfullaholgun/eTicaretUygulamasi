using eTicaretUygulamasi.EntityLayer.Interface;
using eTicaretUygulamasi.EntityLayer.Entities;
using System.ComponentModel;

namespace eTicaretUygulamasi.EntityLayer.Entities
{
    public class Author : IEntity
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Description")]
        public string? Description { get; set; }

        [DisplayName("Image")]
        public string? Img { get; set; }

        [DisplayName("Is Active?")]
        public bool IsActive { get; set; }

        [DisplayName("Order No")]
        public int OrderNo { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }

        public IList<Product>? Products { get; set; }
    }
}