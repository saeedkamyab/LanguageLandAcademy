using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.RegisterIn.ViewModels;
using ManagmentSystem.Domain.RegisterInAgg;
using ManagmentSystem.Domain.RegisterInAgg.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Infrastructure.EfCore.Repositories
{
    public class RegisterRepository : RepositoryBase<long, Register>, IRegisterRepository
    {
        private readonly ManagmentSystemContext _context;

        public RegisterRepository(ManagmentSystemContext context) : base(context)
        {
            _context = context;
        }

        public List<GetAllRegisteration> GetAllRegisteration()
        {
            return _context.Registers.Select(Re => new GetAllRegisteration
            {
                Id = Re.Id,
                CreationDate = Re.CreateDate.ToString(),
                PeopleId = Re.PeopleId,
                TermClassId = Re.TermClassId,
                IsRemoved = Re.IsRemoved,
                LastUpdate = Re.LastUpdate.ToString()
            }).ToList();
        }

        public List<GetAllRegisteration> GetReByTcId(long id)
        {
            return _context.Registers.Select(Re => new GetAllRegisteration
            {
                Id = Re.Id,
                CreationDate = Re.CreateDate.ToString(),
                PeopleId = Re.PeopleId,
                TermClassId = Re.TermClassId,
                IsRemoved = Re.IsRemoved,
                LastUpdate = Re.LastUpdate.ToString()
            }).Where(x => x.TermClassId == id).ToList();
        }

        public EditRegisteration GetRegisterationEditDetails(long id)
        {
            return _context.Registers.Select(Re => new EditRegisteration
            {
                Id = Re.Id,
                Reading = Re.Reading,
                Listening = Re.Listening,
                Writting = Re.Writting,
                Speaking = Re.Speaking,
                MidTerm = Re.MidTerm,
                Final = Re.Final

            }).FirstOrDefault(x => x.Id == id);
        }

        public RegisterationViewModel GetRegisterationItemDetails(long id)
        {
            return _context.Registers.Select(Re => new RegisterationViewModel
            {
                Id = Re.Id,
                CreationDate = Re.CreateDate.ToString(),
                PeopleId = Re.PeopleId,
                TermClassId = Re.TermClassId,
                IsRemoved = Re.IsRemoved,
                LastUpdate = Re.LastUpdate.ToString()
            }).FirstOrDefault(x => x.Id == id);
        }
        public List<GetAllRegisteration> GetUnDeletedRegisteration()
        {
            throw new NotImplementedException();
        }
    }
}
