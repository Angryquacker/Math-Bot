using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class Abs : ModuleBase<SocketCommandContext>
    {
        [Command("absolute")]
        public async Task Abso(double num)
        {
            var result = Convert.ToString(Math.Abs(num));
            await Context.Channel.SendMessageAsync("The absolute value is: " + result);
        }
    }
}
