using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesTest
{
    public class ConsoleLog
    {
        public string Log { get; set; }

        public void Add(string s)
        {
            Log += s;
        }
    }

    public class FakeStringWriter : StringWriter
    {
        private ConsoleLog log;
        private int cursor = 0; //index for the new line - when it's pointing to new line, cursor can be = Entries.count

        public FakeStringWriter(ConsoleLog l)
        {
            log = l;
        }
        public List<string> Entries = new List<string>();
        public override void Write(string str)
        {
            base.Write(str);
            if (Entries.Count == cursor)
            {
                Entries.Add(str);
            }
            else
            {
                Entries[cursor] = Entries[cursor] + str;
            }
            log.Add(str);
        }

        public override void WriteLine(string str)
        {
            base.WriteLine(str);
            if (Entries.Count == cursor)
            {
                Entries.Add(str);
            }
            else
            {
                Entries[cursor] = Entries[cursor] + str;
            }
            cursor++;
            log.Add(str + "\r\n");
        }

        public override void WriteLine()
        {
            WriteLine("");
        }

        public void RemoveEmptyEntries()
        {
            int i = 0;
            while (i < Entries.Count)
            {
                if (String.IsNullOrWhiteSpace(Entries[i]))
                {
                    Entries.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }
    }

    public class FakeStringReader : StringReader
    {
        private ConsoleLog log;
        private FakeStringWriter tw;
        public FakeStringReader(string s, ConsoleLog l, FakeStringWriter tw)
            : base(s)
        {
            log = l;
            this.tw = tw;
        }

        public override string ReadLine()
        {
            string s = base.ReadLine();

            log.Add(s);
            tw.WriteLine();
            return s;
        }
    }
}
