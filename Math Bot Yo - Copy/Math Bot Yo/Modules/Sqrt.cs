using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class Sqrt : ModuleBase<SocketCommandContext>
    {
        [Command("sqrt")]
        public async Task Square(float num)
        {
            var sqrt = Convert.ToString(Math.Sqrt(num));
            await Context.Channel.SendMessageAsync("The Square Root is: " + sqrt);
        }
    }
}
