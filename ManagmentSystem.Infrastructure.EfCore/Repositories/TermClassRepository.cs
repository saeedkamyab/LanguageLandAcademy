﻿using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using ManagmentSystem.Domain.TermClassAgg;
using ManagmentSystem.Domain.TermClassAgg.Interface;
using Microsoft.EntityFrameworkCore;
using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Infrastructure.EfCore.Repositories
{
    public class TermClassRepository :RepositoryBase<long,TermClass>, ITermClassRepository
    {
        private readonly ManagmentSystemContext _context;

        public TermClassRepository(ManagmentSystemContext context): base(context)
        {
            _context = context;
        }
        public List<GetAllTermClassItems> getAllTermClasses()
        {
            return _context.TermClasses.Select(tc => new GetAllTermClassItems
            {
                Id = tc.Id,
                CreateDate = tc.CreateDate.ToString(),
                Day = tc.Day,
                Description = tc.Description,
                EndTime = tc.EndTime,
                StartTime= tc.StartTime,
                IsRemoved = tc.IsRemoved,
                LastUpdate = tc.LastUpdate.ToString()
            }).ToList();
        }

        public EditTermClass GetDetails(int id)
        {
            var termClass = _context.TermClasses.Select(x => new EditTermClass
            {
                Id = x.Id,
                StartTime = x.StartTime,
                EndTime= x.EndTime,
                Day = x.Day,
                Description = x.Description,
                LevelId = x.LevelId,
                RoomId = x.RoomId,
                MappedPeople=MapPeople(x.PeopleLists)
            }).AsNoTracking().FirstOrDefault(x => x.Id == id);
            termClass.PeopleLists = termClass.MappedPeople.Select(x => x.AccountId).ToList();

            return termClass;
        }
        private static List<PeopleDto> MapPeople(IEnumerable<PeopleList> people)
        {
            return people.Select(x => new PeopleDto(x.AccountId)).ToList();
        }
    }
}
