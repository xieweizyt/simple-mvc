using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    public class ComputerBuilder
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public int USB { get; set; } = 2;
        public string KeyBoard { get; set; } = "罗技";

        public ComputerBuilder(string cpu, string ram)
        {
            this.CPU = cpu;
            this.RAM = ram;
        }

        public ComputerBuilder SetUSBCount(int usb)
        {
            this.USB = usb;
            return this;
        }

        public ComputerBuilder SetKeyBoard(string keyBoard)
        {
            this.KeyBoard = keyBoard;
            return this;
        }

        public Computer Build()
        {
            var computer = new Computer(CPU, RAM, USB, KeyBoard);
            return computer;
        }
    }
}
