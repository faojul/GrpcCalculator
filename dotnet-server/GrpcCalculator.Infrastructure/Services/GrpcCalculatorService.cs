
using Contracts.Protos;
using Grpc.Core;
using GrpcCalculator.Application.Interfaces;


namespace GrpcCalculator.Infrastructure.Services
{
    public class GrpcCalculatorService : Calculator.CalculatorBase
    {
        private readonly ICalculatorService _calculatorService;

        public GrpcCalculatorService(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public override async Task<CalculationResponse> Add(CalculationRequest request, ServerCallContext context)
        {
            var domainRequest = new Domain.Models.CalculationRequest(request.A, request.B);
            var domainResponse = await _calculatorService.AddAsync(domainRequest);
            return new CalculationResponse { Result = domainResponse.Result };
        }
    }
}
