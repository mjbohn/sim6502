using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emulator;

[AttributeUsage(AttributeTargets.Method)]
internal class OpcodeAttribute : Attribute
{
    public int Cycles { get; }
    public bool IsUndocumented { get; }
    public bool AddsCycleOnPageCross { get; }

    public OpcodeAttribute(int cycles, bool undocumented = false, bool pageCross = false)
    {
        Cycles = cycles;
        IsUndocumented = undocumented;
        AddsCycleOnPageCross = pageCross;
    }
}
