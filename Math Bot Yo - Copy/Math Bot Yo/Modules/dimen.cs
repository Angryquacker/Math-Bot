using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class dimen : ModuleBase<SocketCommandContext>
    {
        [Command("SquareA")]
        public async Task area(double length, double width)
        {
            var area = length * width;
            await Context.Channel.SendMessageAsync("The area of the entered shape is: " + area);
        }

        [Command("SquareP")]
        public async Task per(double length, double width)
        {
            var perimeter = 2 * length + 2 * width;
            await Context.Channel.SendMessageAsync("The perimeter of the entered shape is: " + perimeter);
        }

        [Command("SquareV")]
        public async Task vol(double length, double width, double height)
        {
            var volume = length * width * height;
            await Context.Channel.SendMessageAsync("The volume of the entered shape is: " + volume);
        }

        [Command("SquareSA")]
        public async Task sur(double length, double width, double height)
        {
            var sA = 2 * (width * length + height * length + height * width);
            await Context.Channel.SendMessageAsync("The surface area of the entered shape is: " + sA);
        }
    }
}
