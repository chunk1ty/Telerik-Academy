namespace Mediator
{
    using System;

    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    public abstract class Participant
    {
        protected Participant(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public AbstractChatRoom ChatRoom { get; set; }

        public void Send(string to, string message)
        {
            ChatRoom.Send(this.Name, to, message);
        }

        public void SendToAll(string message)
        {
            ChatRoom.SendToAll(this.Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, this.Name, message);
        }
    }
}
