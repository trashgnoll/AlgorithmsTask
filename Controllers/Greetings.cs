using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsTask.Models;
using AlgorithmsTask.Views;

namespace AlgorithmsTask.Controllers
{
    public static class Greetings
    {
        /// <summary>
        /// Greet user and show ads if <u>not</u> premium
        /// </summary>
        /// <param name="user"></param>
        public static void Greet( in User user )
        {
            Console.WriteLine($"Greetings, {user.Name}!");
            if (user.IsPremium)
                return;
            Ads.ShowAds();
        }
    }
}
