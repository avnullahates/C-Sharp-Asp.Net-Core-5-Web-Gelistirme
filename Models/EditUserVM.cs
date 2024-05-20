using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Models
{
    public class EditUserVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string ImageUrl { get; set; }

        public string Mail { get; set; }

        public string PhoneNo { get; set; }

        public string UserName { get; set; }




    }
}
