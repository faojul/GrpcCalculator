using GrpcCalculator.Application.Interfaces;
using GrpcCalculator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcCalculator.Application.Services
{
    public class CalculatorService : ICalculatorService
    {
        public async Task<CalculationResponse> AddAsync(CalculationRequest request)
        {
            int result = request.A + request.B;
            return await Task.FromResult(new CalculationResponse(result));
        }
    }
}
