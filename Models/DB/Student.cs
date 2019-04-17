using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models.DB
{
    public partial class Student
    {
        [Display(Name = "Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire"),
            MinLength(5, ErrorMessage = "Minimum 5 caractères"),
            Display(Name = "Prénom")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire"),
            MinLength(5, ErrorMessage = "Minimum 5 caractères"),
            Display(Name = "Nom")]
        public string LastName { get; set; }

        [Display(Name = "Sexe")]
        public string Gender { get; set; }

        [Display(Name = "Naissance le"), DataType(DataType.DateTime)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Date création"), DataType(DataType.DateTime)]
        public DateTime? DateOfRegistration { get; set; }

        [Display(Name = "Téléphone"), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Mail"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }



        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
