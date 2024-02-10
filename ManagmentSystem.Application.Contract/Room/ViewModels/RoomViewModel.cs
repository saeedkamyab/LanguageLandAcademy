namespace ManagmentSystem.Application.Contract.Room.ViewModels
{
    public class RoomViewModel
    {
        #region Properties

        public int Id { get; set; }

        public string RoomName { get; set; }

        public string Descriptions { get; set; }

        public string CreateDate { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        #endregion
    }
}
