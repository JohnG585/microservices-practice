using System;

namespace MSPrac.Common.Commands
{
    public interface IAuthenticatedCommand : ICommand
    {
        Guid UserId {get; set;}
    }
}