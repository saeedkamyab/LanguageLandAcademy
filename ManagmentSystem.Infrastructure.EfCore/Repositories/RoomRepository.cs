using ManagmentSystem.Application.Contract.Room.ViewModels;
using ManagmentSystem.Application.Contract.Tuition.ViewModels;
using ManagmentSystem.Domain.RoomAgg;
using ManagmentSystem.Domain.RoomAgg.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Infrastructure.EfCore.Repositories
{
    public class RoomRepository : RepositoryBase<int, Room>, IRoomRepository
    {
        private readonly ManagmentSystemContext _context;

        public RoomRepository(ManagmentSystemContext context) : base(context)
        {
            _context = context;
        }

        public List<AllRooms> GetAllRooms()
        {
            return _context.Rooms.Select(roo => new AllRooms
            {
                Id = roo.Id,
                CreateDate = roo.CreateDate.ToString(),
                IsRemoved = roo.IsRemoved,
                LastUpdate = roo.LastUpdate.ToString(),
                RoomName = roo.RoomName,
                Descriptions = roo.Descriptions

            }).ToList();
        }
    }
}
