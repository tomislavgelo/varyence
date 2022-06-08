using System;

namespace InterviewTestApplication
{
    public class Feture1Command : IValidatabe
    {
        public string Param1 { get; }
        public string Param2 { get; }
        public string Param3 { get; }
        public string Param4 { get; }
        public string Param5 { get; }
        
        public Feture1Command(
            string param1,
            string param2,
            string param3,
            string param4,
            string param5)
        {
            Param1 = param1;
            Param2 = param2;
            Param3 = param3;
            Param4 = param4;
            Param5 = param5;
        }

        #region validation

        /// <summary>
        /// <see cref="IValidatabe.IsValid"/>
        /// </summary>
        /// <returns></returns>
        public bool IsValid() => new Validator().Validate(this).IsValid;

        /// <summary>
        /// <see cref="IValidatabe.Validate"/>
        /// </summary>
        public void Validate() => new Validator().ValidateAndThrow(this);
        
        private class Validator : AbstractValidator<Feture1Command>
        {
            public Validator()
            {
                RuleFor(x => x.Param1).NotNull().NotEmpty();
                RuleFor(x => x.Param2).NotNull().NotEmpty();
                RuleFor(x => x.Param3).NotNull().NotEmpty();
                RuleFor(x => x.Param4).NotNull().NotEmpty();
                RuleFor(x => x.Param5).NotNull().NotEmpty().MinLength(3);
            }
        }

        #endregion
    }
}