using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Blazer
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }

    public class dateComp: BlazorComponent
    {
        public DateTime date1 { get {
                return DateTime.Now;
            } }

        public DateTime today { get { return new DateTime(2018, 04, 24); } }

        public TimeSpan counter {
            get {
                return today.AddDays(20).TimeOfDay - DateTime.Now.TimeOfDay;
                
                }
        }
    }
}
