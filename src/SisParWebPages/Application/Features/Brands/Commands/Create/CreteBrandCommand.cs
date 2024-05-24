using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;

public class CreteBrandCommand:IRequest<CreatedBrandResponse>
{
    public string Name { get; set; }

    public class CreteBrandCommandHandler : IRequestHandler<CreteBrandCommand, CreatedBrandResponse>
    {
        public Task<CreatedBrandResponse>? Handle(CreteBrandCommand request, CancellationToken cancellationToken)
        {
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = request.Name;
            createdBrandResponse.Id = new Guid();
            return null;
        }
    }
}
