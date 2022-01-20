using MatthiWare.CommandLine.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToBytes
{
    public class ProgramOptions
    {
        [Required, Name("file","i" ), Description("file will be converted to hex")]
        public string Input { get; set; }

        [Required, Name("outputfile", "o"), Description("file with result of conversion")]
        public string Output { get; set; }
    }
}
