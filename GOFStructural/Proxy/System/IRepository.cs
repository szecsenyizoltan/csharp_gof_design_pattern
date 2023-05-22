namespace Proxy.System
{
    internal interface IRepository
    {
        void AddName(string name);
        void RemoveName(string name);

        string[] ListNames();
    }
}