using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

        private int _kernalStartAdress;
        private int _basicStartAddress;
        private int _programStartAdress;
              
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
        [Category("Windows")]
        [DisplayName("Stack window position")]
        [DefaultValue(typeof(Point),"0,10")]
        public Point MwfStackLocation { get => _mwfStackLocation; set => _mwfStackLocation = value; }

        [Description("Zeropage window position")]
        [Category("Windows")]
        [DisplayName("Zeropage window position")]
        [DefaultValue(typeof(Point), "0,360")]
        public Point MwfZeropageLocation { get => _mwfZeropageLocation; set => _mwfZeropageLocation = value; }

        [Description("MemoryRange window position")]
        [Category("Windows")]
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
        [Category("Windows")]
        //[DisplayName("Main window position")]
        [DefaultValue(typeof(Point), "660,75")]
        public Point MainFormLocation { get => _mainFormLocation; set => _mainFormLocation = value; }

        [Category("Windows")]
        [DisplayName("Show stack window on startup")]
        [DefaultValue(false)]
        public bool ShowStackOnStartUP { get => _showStackOnStartUP; set => _showStackOnStartUP = value; }

        [Category("Windows")]
        [DisplayName("Show zeropage window on startup")]
        [DefaultValue(false)]
        public bool ShowZeroPageOnstartUp { get => _showZeroPageOnstartUp; set => _showZeroPageOnstartUp = value; }

        [Category("Windows")]
        [DisplayName("Show memory-range window on startup")]
        [DefaultValue(false)]
        public bool ShowMemoryRangeOnStartUp { get => _showMemoryRangeOnStartUp; set => _showMemoryRangeOnStartUp = value; }
        
        [Category("Memory")]
        [DisplayName("Start of KERNAL ROM")]
        [TypeConverter(typeof(HexConverter))]
        [DefaultValue(0xE000)]
        public int KernalStartAdress { get => _kernalStartAdress; set => _kernalStartAdress = value; }
               
        [Category("Memory")]
        [DisplayName("Start of BASIC ROM")]
        [TypeConverter(typeof(HexConverter))]
        [DefaultValue(0xA000)]
        public int BasicStarAddress { get => _basicStartAddress; set => _basicStartAddress = value; }

        [Category("Memory")]
        [DisplayName("Start of program space")]
        [TypeConverter(typeof(HexConverter))]
        [DefaultValue(0x200)]
        public int ProgramStartAdress { get => _programStartAdress; set => _programStartAdress = value; }
    }

    public class HexConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                string hexString = (string)value;
                hexString = hexString.Replace("0x", ""); 
                int intValue = int.Parse(hexString, NumberStyles.HexNumber); 
                
                return intValue;
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                int intValue = (int)value;
                return "0x" + intValue.ToString("X4"); 
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

   
}
