using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar mailini boş geçemezsiniz!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifresini boş geçemezsiniz!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında bilgisini boş geçemezsiniz!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar unvanını boş geçemezsiniz!");

            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı en az 2 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar soyadı adı en az 2 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterMail).MinimumLength(15).WithMessage("Yazar maili en az 15 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterPassword).MinimumLength(6).WithMessage("Yazar şifresi en az 6 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterAbout).MinimumLength(2).WithMessage("Yazar hakkında bilgisi en az 2 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterTitle).MinimumLength(3).WithMessage("Yazar unvanı en az 2 karakterden oluşmalıdır!");

            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı en fazla 50 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Yazar soyadı en fazla 50 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterMail).MaximumLength(200).WithMessage("Yazar maili en fazla 200 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterPassword).MaximumLength(200).WithMessage("Yazar şifresi en fazla 200 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterAbout).MaximumLength(100).WithMessage("Yazar hakkında bilgisi en fazla 100 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterTitle).MaximumLength(50).WithMessage("Yazar unvanı bilgisi en fazla 50 karakterden oluşmalıdır!");
        }
    }
}
