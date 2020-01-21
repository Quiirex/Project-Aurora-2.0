using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Aurora_2._0
{
    public class Commands : ModuleBase
    {
        [Command("ping")]
        public async Task Ping()
        {
            var msg = await ReplyAsync("***Calculating***");

            await ReplyAsync($"***{(DateTime.Now - msg.Timestamp.LocalDateTime).TotalMilliseconds}*** ms.");

            //await Context.Message.DeleteAsync();
            await msg.DeleteAsync();
        }
        [Command("kick")]
        public async Task Kick(SocketGuildUser mention, string reason = null)
        {
            if (mention != null)
            {
                var channel = await mention.GetOrCreateDMChannelAsync();
                await channel.SendMessageAsync(reason == null ? $"Kicked from server {Context.Guild.Name} for an unspecified reason." 
                    : $"Kicked from server {Context.Guild.Name} for ***{reason}***");
                await Task.Delay(2000);
                await mention.KickAsync();
                await ReplyAsync(reason == null ? $"Kicked { mention.Username} for an unspecified reason."
                    : $"Kicked {mention.Username} for {reason}");
            }
            else
            {
                await ReplyAsync("Specify the user first!");
            }
        }
        [Command("skrivnostvere")]
        public async Task SkrivnostVere()
        {
            await ReplyAsync($"Tvojo smrt oznanjamo, Gospod, in tvoje vstajenje slavimo, dokler ne prideš v slavi.");
        }
    }
}
