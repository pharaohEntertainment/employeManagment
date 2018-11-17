using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeMangment.Models
{
    public class Employe
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "برجاء ادخال الرقم القومي")]
        [MaxLength(14, ErrorMessage = "الرقم القومي بجب ان يتكون من 14 رقم فقظ")]
        [MinLength(14, ErrorMessage = "الرقم القومي بجب ان يتكون من 14 رقم ")]
        public string nationalId { get; set; }

        [Required(ErrorMessage = "برجاء ادخال اسم الموظف")]
        public string name { get; set; }

        [Required(ErrorMessage = "برجاء ادخال رقم الموبيل")]
        [MaxLength(11, ErrorMessage = "رقم الموبيل بجب ان يتكون من 11 رقم فقظ")]
        [MinLength(11, ErrorMessage = "رقم الموبيل بجب ان يتكون من 11 رقم ")]
        public string mobileNumber { get; set; }

        [Required(ErrorMessage = "برجاء ادخال العنوان")]
        public string address { get; set; }

        [Required(ErrorMessage = "برجاء ادخال نسبة العجز و ان كانت 0")]
        public int disablityPrecentage { get; set; }

        [Required(ErrorMessage = "برجاء ادخال تاريخ الميلاد")]
        public DateTime birthDate { get; set; }

        [Required(ErrorMessage = "برجاء ادخال تاريخ التعاقد")]
        public DateTime contractionDate { get; set; }

    }
}