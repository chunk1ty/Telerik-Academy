namespace Library
{

    public class Admin : Profile, IAdmin
    {
        public Admin(string name, string password) 
            :base(name, password, ProfileType.Administrator)
        {
        }

        public void SendToLibrary(string[] data)
        {
            var readable = Library.Instance.readableItemsFactory.CreateReadableItem(data);
            Library.Instance.SaveReadableItem(readable);
            Library.Instance.AddReadableItem(readable);
        }

        public void RemoveFromLibrary(IReadable readable)
        {
            Library.Instance.RemoveReadableItem(readable);
        }
    }
}
