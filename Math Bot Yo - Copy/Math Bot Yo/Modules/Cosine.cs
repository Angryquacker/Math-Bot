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
        [Command("sine")]
        public async Task sine(double num)
        {
            var result = Math.Sin(num);
            await Context.Channel.SendMessageAsync("The Sine of the entered number is: " + result);
        }
        [Command("tangent")]
        public async Task tan(double num)
        {
            var result = Math.Tan(num);
            await Context.Channel.SendMessageAsync("The Tangent of the entered number is: " + result);
        }
    }
}
