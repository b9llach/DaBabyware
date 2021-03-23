using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace HoudiniDiscordRPS
{
    class discordAPI
    {
        public DiscordRpcClient Client { get; private set; }

        public void Setup()
        {
            Client = new DiscordRpcClient("823913803162451989");  //Creates the client
            Client.Initialize();                            //Connects the client
            Client.SetPresence(new RichPresence()
            {
                Details = "Houdini Rust Script",
                State = "houdini.xyz",
                Assets = new Assets()
                {
                    LargeImageKey = "image_large",
                    LargeImageText = "Houdini Slight Finesse",
                    SmallImageKey = "image_small"
                }
            });
        }
        void Cleanup()
        {
            Client.Dispose();
        }
        //void Start()
        //{
        //    //Creates a new client, telling it not to automatically invoke the events on RPC thread.
        //    Client = new DiscordRpcClient("820485401227690016", autoEvents: false);
        //    Client.Initialize();
        //}

        void Update()
        {
            //Invoke the events once per-frame. The events will be executed on calling thread.
            Client.Invoke();
        }

    }
}
