﻿using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Http;


namespace RemotingServer
{
    public class RemoteObjectsServer
    {
        public RemoteObjectsServer() { }
    }


    //service class
    public class Service : MarshalByRefObject
    {
        public string SayHello(string s)
        {
            return "Hello" + s;
        }

        public int HighestNumber(int n1, int n2)
        {
            int maxnumber = (Math.Max(n1, n2));
            Console.WriteLine("Remote Call Executed..");
            return maxnumber;
        }
        public int LowestNumber(int n1, int n2)
        {
            int minnumber = (Math.Min(n1, n2));
            Console.WriteLine("Remote Call Executed..");
            return minnumber;
        }

        //managing objects lifetime of either Singleton or ClientActivated objects
        public override object InitializeLifetimeService()
        {
            ILease lease = (ILease)base.InitializeLifetimeService();
            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(25);
                lease.SponsorshipTimeout = TimeSpan.FromSeconds(25);
                lease.RenewOnCallTime = TimeSpan.FromSeconds(25);
            }
            return lease;
        }

    }
    //server class
    //it hosts the services by registering them
    class Server
    {
        [Obsolete]
        static void Main(string[] args)
        {
            //create a new channel for communication
            HttpChannel c = new HttpChannel(85); //port number
            TcpChannel tc = new TcpChannel(8089);
            //register the channel
            ChannelServices.RegisterChannel((IChannel)c);

            //configure all known services
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "OurFirstRemoteService",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services started at Port No: 85...");
            Console.WriteLine("Press any Key to Stop the Server Services..");
            Console.ReadLine();
        }
    }
}
