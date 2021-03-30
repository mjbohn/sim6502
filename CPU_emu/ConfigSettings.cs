using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emulator
{
    class ConfigSettings
    {
        private bool _stepping;
        private bool _slow;
        private Point _mwfStackLocation;
        private Point _mwfZeropageLocation;
        private Point _mwfMemoryRangeLocation;

        public bool Stepping { get => _stepping; set => _stepping = value; }
        public bool Slow { get => _slow; set => _slow = value; }
        public Point MwfStackLocation { get => _mwfStackLocation; set => _mwfStackLocation = value; }
        public Point MwfZeropageLocation { get => _mwfZeropageLocation; set => _mwfZeropageLocation = value; }
        public Point MwfMemoryRangeLocation { get => _mwfMemoryRangeLocation; set => _mwfMemoryRangeLocation = value; }
    }
}
