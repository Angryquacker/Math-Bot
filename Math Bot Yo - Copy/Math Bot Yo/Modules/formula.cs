using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class formula : ModuleBase<SocketCommandContext>
    {
        [Command("formula")]
        public async Task form(string shape)
        {
            string[] formPics = { };
            string pic;
            switch (shape.ToLower())
            {
                case "square":
                    pic = "https://imgur.com/iIzYjik";
                    break;
                case "rectangle":
                    pic = "https://imgur.com/R3OpaTH";
                    break;
                case "circle":
                    pic = "https://imgur.com/TZQWGJo";
                    break;
                case "triangle":
                    pic = "https://imgur.com/eZFi9N9";
                    break;
                default:
                    pic = "Not a valid shape";
                    break;
            }
            await Context.Channel.SendMessageAsync(pic);
        }

        [Command("helpF")]
        public async Task helpForm()
        {
            string[] shapes = { "square", "rectangle", "circle", "triangle"}; //Future shapes:  "cube", "rectangular prism", "pyramid", "sphere" 
            await Context.Channel.SendMessageAsync("The following shapes are valid: " + string.Join(", ", shapes));
        }
    }
}
