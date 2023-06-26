using CommunityToolkit.Mvvm.ComponentModel;
using MauiPageValidations.Validations;


namespace MauiPageValidations.MVVM.Models
{
    public class ModelBase: ObservableValidator
    {
        Validator validator;
        public ModelBase() => validator = new Validator(this);

        public Validator Validator => validator;
    } 
}