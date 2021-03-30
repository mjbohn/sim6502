using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emulator
{
    class ConfigSettings
    {
        private bool _stepping;
        private bool _slow;

        public bool Stepping { get => _stepping; set => _stepping = value; }
        public bool Slow { get => _slow; set => _slow = value; }
    }
}
