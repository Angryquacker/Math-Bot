using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class Cosine : ModuleBase<SocketCommandContext>
    {
        [Command("cosine")]
        public async Task Cos(double angle)
        {
            var result = Convert.ToString(Math.Cos(angle));
            await Context.Channel.SendMessageAsync("The Cosine of the entered angle is: " + result);
        }
    }
}
