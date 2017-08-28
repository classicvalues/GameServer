using System.Text;
using LeagueSandbox.GameServer.Logic.Packets.PacketArgs;
using LeagueSandbox.GameServer.Logic.Packets.PacketHandlers;

namespace LeagueSandbox.GameServer.Logic.Packets.PacketDefinitions.S2C
{
    public class BasicTutorialMessageWindow : BasePacket
    {
        public BasicTutorialMessageWindow(BasicTutorialMessageWindowArgs args)
            : base(PacketCmd.PKT_S2C_BasicTutorialMessageWindow)
        {
            // The following structure might be incomplete or wrong
            buffer.Write(Encoding.Default.GetBytes(args.Message)); // It seems to show up to 189 characters, which is strange
            buffer.Write(0x00);
        }
    }
}