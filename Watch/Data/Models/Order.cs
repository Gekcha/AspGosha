using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order // Соло
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя:")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия:")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string address { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
