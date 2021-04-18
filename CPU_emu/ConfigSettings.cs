using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_emulator
{
    [DefaultProperty("Stepping")]
    public class ConfigSettings
    {
        private bool _stepping;
        private bool _slow;
        private Point _mwfStackLocation;
        private bool _showStackOnStartUP, _showZeroPageOnstartUp, _showMemoryRangeOnStartUp;
        private Point _mwfZeropageLocation;
        private Point _mwfMemoryRangeLocation;
        private Point _mainFormLocation;
        private Color _sevenSegBackgroundColor;
        private Color _sevenSegDarkColor;
        private Color _sevenSegLightColor;
        
        [ReadOnly(true)]
        [Description("")]
        [Category("CPU")]
        [DisplayName("Stepping Mode")]
        public bool Stepping { get => _stepping; set => _stepping = value; }
       
        
        [ReadOnly(true)]
        [Description("")]
        [Category("CPU")]
        [DisplayName("Slow Mode")]
        public bool Slow { get => _slow; set => _slow = value; }

        [Description("Stack window position")]
        [Category("Memory")]
        [DisplayName("Stack window position")]
        [DefaultValue(typeof(Point),"0,10")]
        public Point MwfStackLocation { get => _mwfStackLocation; set => _mwfStackLocation = value; }

        [Description("Zeropage window position")]
        [Category("Memory")]
        [DisplayName("Zeropage window position")]
        [DefaultValue(typeof(Point), "0,360")]
        public Point MwfZeropageLocation { get => _mwfZeropageLocation; set => _mwfZeropageLocation = value; }

        [Description("MemoryRange window position")]
        [Category("Memory")]
        [DisplayName("MemoryRange window position")]
        [DefaultValue(typeof(Point), "1250,350")]
        public Point MwfMemoryRangeLocation { get => _mwfMemoryRangeLocation; set => _mwfMemoryRangeLocation = value; }


        [Description("LED background color")]
        [Category("LED colors")]
        [DisplayName("LED background color")]
        public Color SevenSegBackgroundColor { get => _sevenSegBackgroundColor; set => _sevenSegBackgroundColor = value; }

        [Description("LED dark color")]
        [Category("LED colors")]
        [DisplayName("LED dark color")]
        public Color SevenSegDarkColor { get => _sevenSegDarkColor; set => _sevenSegDarkColor = value; }

        [Description("LED light color")]
        [Category("LED colors")]
        [DisplayName("LED light color")]
        public Color SevenSegLightColor { get => _sevenSegLightColor; set => _sevenSegLightColor = value; }

        [Description("Main window position")]
        //[DisplayName("Main window position")]
        [DefaultValue(typeof(Point), "660,75")]
        public Point MainFormLocation { get => _mainFormLocation; set => _mainFormLocation = value; }

        [Category("Memory")]
        [DisplayName("Show stack window on startup")]
        [DefaultValue(false)]
        public bool ShowStackOnStartUP { get => _showStackOnStartUP; set => _showStackOnStartUP = value; }

        [Category("Memory")]
        [DisplayName("Show zeropage window on startup")]
        [DefaultValue(false)]
        public bool ShowZeroPageOnstartUp { get => _showZeroPageOnstartUp; set => _showZeroPageOnstartUp = value; }

        [Category("Memory")]
        [DisplayName("Show memory-range window on startup")]
        [DefaultValue(false)]
        public bool ShowMemoryRangeOnStartUp { get => _showMemoryRangeOnStartUp; set => _showMemoryRangeOnStartUp = value; }
    }

    
}
