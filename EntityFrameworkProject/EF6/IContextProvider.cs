namespace EntityFrameworkProject.EF6
{
    public interface IContextProvider<out T>
    {
        T Provide(object token = null);
    }
}
