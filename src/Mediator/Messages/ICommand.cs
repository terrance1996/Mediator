namespace Mediator
{
    public interface IBaseCommand : IMessage { }
    public interface ICommand : ICommand<Unit> { }
    public interface ICommand<out TResponse> : IBaseCommand { }
}