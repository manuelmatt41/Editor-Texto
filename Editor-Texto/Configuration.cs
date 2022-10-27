using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_Texto
{
    internal class BinaryWriterConfiguration : BinaryWriter
    {
        public BinaryWriterConfiguration(Stream str) : base(str)
        {
        }

        public void Write(Configuration c)
        {
            base.Write(c.wordWrap);
            base.Write(((int)c.characterCasing));
            base.Write(c.foreColor.R);
            base.Write(c.foreColor.G);
            base.Write(c.foreColor.B);
            base.Write(c.backColor.R);
            base.Write(c.backColor.G);
            base.Write(c.backColor.B);
        }
    }

    internal class BinaryReaderConfiguration : BinaryReader
    {
        public BinaryReaderConfiguration(Stream str) : base(str)
        {
        }

        public Configuration Read()
        {
            Configuration c;
            c.wordWrap = base.ReadBoolean();
            c.characterCasing = (CharacterCasing)base.ReadInt32();
            c.foreColor = Color.FromArgb(base.ReadByte(), base.ReadByte(), base.ReadByte());
            c.backColor = Color.FromArgb(base.ReadByte(), base.ReadByte(), base.ReadByte());
            return c;
        }
    }


    internal struct Configuration
    {
        public Configuration()
        {
            this.wordWrap = false;
            this.characterCasing = CharacterCasing.Normal;
            this.foreColor = Color.Black;
            this.backColor = Color.White;
        }
        public bool wordWrap;
        public CharacterCasing characterCasing;
        public Color foreColor;
        public Color backColor;
    }
}
