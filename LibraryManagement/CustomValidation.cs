using System.ComponentModel.DataAnnotations;

namespace LibraryManagement
{
    public class NoHorrorTwoAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var book = (Book)validationContext.ObjectInstance;
            if (book.Genre == Book.BookGenre.Horror)
            {
                return new ValidationResult("Sorry, You can't add horror books");
            }
            return ValidationResult.Success;
        }

    }


    public class EnglishOnlyAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var book = (Book)validationContext.ObjectInstance;
            if(book.Language != "English")
            {
                return new ValidationResult("Sorry, Only English books can be added");
            }
            return ValidationResult.Success;
        }
    }
}
