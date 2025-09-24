using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure;

public class FakeMessageSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine(message);
    }
}
