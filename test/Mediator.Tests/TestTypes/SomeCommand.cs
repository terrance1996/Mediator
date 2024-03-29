using System;

namespace Mediator.Tests.TestTypes;

public sealed record SomeCommand(Guid Id) : ICommand<SomeResponse>;

public sealed record SomeCommandWithoutResponse(Guid Id) : ICommand;

public readonly struct SomeStructCommand : ICommand
{
    public SomeStructCommand(Guid id)
    {
        Id = id;
        CorrelationId = Guid.NewGuid();
    }

    public Guid Id { get; }

    public Guid CorrelationId { get; }
}

#pragma warning disable MSG0005 // MediatorGenerator message warning
public sealed record SomeCommandWithoutHandler(Guid Id) : ICommand;
#pragma warning restore MSG0005 // MediatorGenerator message warning
