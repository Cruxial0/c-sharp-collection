using System;
using System.Threading.Tasks;
using PluginSystem.Interfaces;
using PluginSystem;

namespace PluginSystem.Plugins
{
    public class HelpPlugin : ISnoozePlugin
    {
        public string Name => "Help";
        public string Description => "Lists all recorded plugins.";
        public async Task Execute(string[] parameters)
        {
            //Save Old Color
            var oldColor = Console.ForegroundColor;
            Console.WriteLine(Environment.NewLine);
            
            //Find and write all plugins to console
            foreach (var plugin in PluginLoader.Plugins)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{plugin.Name}: ");
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{plugin.Description}\n");
            }

            //Restore old color
            Console.ForegroundColor = oldColor;
            
            //Await Task Completion
            await Task.CompletedTask;
        }
    }
}