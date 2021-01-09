using System;
using System.Collections;

namespace DimsQ
{
    interface IServer
    { }
    interface IClient
    { }

    class Foo
    {
        IServer server;
        IClient client;

        Queue messages;
    }

}
