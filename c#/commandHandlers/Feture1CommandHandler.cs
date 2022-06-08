using System;

namespace InterviewTestApplication
{
    public class Feture1CommandHandler: ICommandHandler<Feture1Command>
    {
        private readonly ISomeRepository _someRepository;
        private readonly ISomeService _someService;
        private readonly ISomeLogger _logger;

        public Feture1CommandHandler(
            ISomeRepository someRepository,
            ISomeService someService,
            ISomeLogger logger)
        {
            _someRepository = someRepository;
            _someService = someService;
            _logger = logger;
        }

        public async Task<Feature1> HandleAsync(Feture1Command command)
        {
            command.Validate();
            
            Assertparam1(command.Param1);

            AssertFeatureDoesNotExist(command.Param2);

            var feature = new Feature1(
                param1: command.Param1,
                param2: command.Param2,
                param3: command.Param3,
                param4: command.Param4,
                param5: command.Param5
            );

            await _someRepository.AddAsync(feature);

            await _someRepository.SaveAsync();

            return feature;
        }

        #region private 

        private void Assertparam1(string param1)
        {
            if (string.IsNullOrEmpty(param1))
            {
                throw new ArgumentException(nameof(param1));
            }
        }

        private void Assertparam5(string param5)
        {
            if (string.IsNullOrEmpty(param5) || param5.Length < 3)
            {
                throw new ArgumentException(nameof(param5));
            }
        }

        private async void AssertFeatureDoesNotExist(string param2)
        {
            if (await _someRepository.AnyAsync(x => x.Param1 == param2))
            {
                throw new Exception($"Feature 1 with param2 = {param2} already exists");
            }
        }

        #endregion
    }
}