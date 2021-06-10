using System.Threading.Tasks;

namespace PluginSystem.Interfaces
{
    public interface ISnoozePlugin
    {
        /// <summary>
        /// Plugin Name.
        /// </summary>
        string Name { get; }
        
        /// <summary>
        /// Plugin Description.
        /// </summary>
        string Description { get; }
        
        /// <summary>
        /// Execution function for plugins.
        /// </summary>
        /// <param name="parameters">Parameters used in plugin execution.</param>
        /// <returns></returns>
        Task Execute(string[] parameters);
    }
}