# sim6502
6502 CPU simulator in C#

Inspired by Dave Poos [6502emulator](https://github.com/davepoo/6502Emulator) and due to the fact that I wanted to refresh my C# skills, I started this project.

The main focus is set to the visual aspects of the emulation. I want to visualize what's going on in the registers, flags and memory.
There's no aim to achieve real time behavior or counting cycles correctly.

There are two display modes implemented.
## txt-mode

![](/Screenshots/6502txt.png?raw=true "txt-mode")

## led-mode

![](/Screenshots/6502led.png?raw=true "led-mode")

For the LED-mode I'm using ***Dmitry Brants*** [SevenSegment](https://github.com/dbrant/SevenSegment)

There are separate forms to watch stack, zeropage or any random part of the memory.

![](/Screenshots/6502sp.png?raw=true "stack") ![](/Screenshots/6502zp.png?raw=true "zeropage")![](/Screenshots/6502mr.png?raw=true "memory range")

At this stage of the project, there are only a few opcodes implemented so far. But there's more to come.

OC_BRK    = 0x00,  
***LDA  
OC_LDA_IM = 0xA9,  
OC_LDA_ZP = 0xA5,  
OC_LDA_ZPX = 0xB5,  
***LDX  
OC_LDX_IM = 0xA2,  
OC_LDX_ZP = 0xA6,  
OC_LDX_ZPY = 0xB6,  
***LDY  
OC_LDY_IM = 0xA0,  
OC_LDY_ZP = 0xA4,  
OC_LDY_ZPX = 0xB4,  
  
***JMP  
CO_JMP_ABS = 0x4C,  
  
  
***Stack  
OC_PHA    = 0x48,  
OC_PLA    = 0x68  

Any comments, ideas, critics? Drop me a line or open an [issue](https://github.com/mjbohn/sim6502/issues).  


