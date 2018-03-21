using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class round : ModuleBase<SocketCommandContext>
    {
        [Command("round")]
        public async Task Rounds(double num)
        {
            var result = Convert.ToString(Math.Round(num));
            await Context.Channel.SendMessageAsync("Your number rounded to the nearest integer is: " + result);
        }
    }
}
