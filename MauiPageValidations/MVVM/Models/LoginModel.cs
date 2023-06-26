using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MauiPageValidations.Validations;
using MauiPageValidations.Validations.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPageValidations.MVVM.Models
{
    public partial class LoginModel : ModelBase
    {
        [ObservableProperty]
        [Required(ErrorMessage = "The User Name field is required.")]
        string username;

        [ObservableProperty]
        [Required]
        [MinLength(5)]
        [Password(
            IncludesLower = true,
            IncludesNumber = true,
            IncludesSpecial = true,
            IncludesUpper = true)]
        string password;
    }
}
