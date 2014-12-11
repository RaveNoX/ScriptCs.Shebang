#region Usings

using ScriptCs.Contracts;

#endregion

namespace ScriptCs.ShebangModule
{
    public class ShebangLineProcessor : ILineProcessor
    {
        public bool ProcessLine(IFileParser parser, FileParserContext context, string line, bool isBeforeCode)
        {            
            return !isBeforeCode && IsShebang(line);
        }

        private bool IsShebang(string line)
        {
            if (string.IsNullOrWhiteSpace(line)) return false;
            return line.StartsWith("#!") && line.Length > 2;
        }
    }
}