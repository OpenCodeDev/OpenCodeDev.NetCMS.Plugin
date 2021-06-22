using System;
using System.Reflection;
using OpenCodeDev.NetCMS.Plugin.Core.DataAnnotation;
using OpenCodeDev.NetCMS.Core.Plugin;
namespace OpenCodeDev.NetCMS.MyPlugin
{
    public class Main: PluginBase
    {

        /// <summary>
        /// Entry Point
        /// </summary>
        [AddAction("_INIT_", "Activator")]
        public void Activator(){

        }

        /// <summary>
        /// Setup Entry Point
        /// </summary>
        [AddAction("AdminInit", "LoadPlugin")]
        public void LoadPlugin(){
            
        }


    }
}
