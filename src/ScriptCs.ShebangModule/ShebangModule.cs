#region Usings

using System;
using ScriptCs.Contracts;

#endregion

namespace ScriptCs.ShebangModule
{
    [Module("shebang", Autoload = true)]
    public class ShebangModule : IModule
    {
        public void Initialize(IModuleConfiguration config)
        {            
            config.LineProcessor<ShebangLineProcessor>();            
        }
    }
}