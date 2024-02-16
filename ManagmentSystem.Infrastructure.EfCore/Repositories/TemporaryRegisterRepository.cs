using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels;
using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using ManagmentSystem.Domain.TemporaryRegisterAgg;
using ManagmentSystem.Domain.TemporaryRegisterAgg.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Infrastructure.EfCore.Repositories
{
    public class TemporaryRegisterRepository : RepositoryBase<int, TemporaryRegister>, ITemporaryRegisterRepository
    {
        private readonly ManagmentSystemContext _context;

        public TemporaryRegisterRepository(ManagmentSystemContext context) : base(context)
        {
            _context = context;
        }

        public List<AllTemporaryRegister> GetAllTeRegister()
        {
            return _context.TemporaryRegisters.Select(teRegister => new AllTemporaryRegister
            {
                Id = teRegister.Id,
                CreateDate = teRegister.CreateDate.ToString(),
                FullName = teRegister.FullName,
                PhoneNumbers = teRegister.PhoneNumbers,
                Description = teRegister.Description,
                IsRemoved = teRegister.IsRemoved,
                LastUpdate = teRegister.LastUpdate.ToString()

            }).ToList();
        }

        public EditTemporaryRegister GetDetails(int id)
        {
            return _context.TemporaryRegisters.Select(x => new EditTemporaryRegister
            {
                Id = x.Id,
                FullName = x.FullName,
                PhoneNumbers = x.PhoneNumbers,
                Description = x.Description,
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
