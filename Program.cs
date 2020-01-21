using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Aurora_2._0
{
    class Program
    {
        public DiscordSocketClient Client;
        public CommandHandler Handler;
        static void Main(string[] args) => new Program().Start().GetAwaiter().GetResult();

        public async Task Start()
        {
            Client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Info
            });
            Client.Log += Log;

            Handler = new CommandHandler();

            await Client.LoginAsync(Discord.TokenType.Bot, "MjczMTM1OTc0NjA5ODQ2Mjcy.Xibuzg.jVJL-OH0gSQ9oumQ0AsxZqEcDOc", true);

            await Client.StartAsync();

            await Handler.Install(Client);

            await Task.Delay(-1);
        }
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
