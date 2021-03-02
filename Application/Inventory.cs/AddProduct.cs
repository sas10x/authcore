

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Inventory
{
    public class AddProduct
    {
        public class Command : IRequest
        {
               public List<Product> Products { get; set; }  
        }

         public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IUserAccessor _userAccessor;
            public Handler(DataContext context, IUserAccessor userAccessor)
            {
                _userAccessor = userAccessor;
               _context = context;   
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                foreach (Product aPart in request.Products)
                {
                    _context.Products.Add(aPart);
                }
                
                var success = await _context.SaveChangesAsync() > 0;
                if (success) return Unit.Value;
                       throw new Exception("Problem saving changes");
            }
        }
    }
}