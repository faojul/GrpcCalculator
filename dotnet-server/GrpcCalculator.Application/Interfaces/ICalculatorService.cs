using GrpcCalculator.Domain.Models;

namespace GrpcCalculator.Application.Interfaces
{
    public interface ICalculatorService
    {
        Task<CalculationResponse> AddAsync(CalculationRequest request);
    }
}
