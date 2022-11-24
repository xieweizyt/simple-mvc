using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public int USB { get; set; } = 2;
        public string KeyBoard { get; set; } = "罗技";

        public Computer(string cpu, string ram)
        {
            this.CPU = cpu;
            this.RAM = ram;
        }

        public Computer(string cpu, string ram, int usb)
        {
            this.CPU = cpu;
            this.RAM = ram;
            this.USB = usb;
        }

        public Computer(string cpu, string ram, int usb, string keyBoard)
        {
            this.CPU = cpu;
            this.RAM = ram;
            this.USB = usb;
            this.KeyBoard = keyBoard;
        }

        public void SetUSBCount(int usb)
        {
            this.USB = usb;
        }

        public void SetKeyBoard(string keyBoard)
        {
            this.KeyBoard = keyBoard;
        }

        public void Display()
        {
            Console.WriteLine($"CPU={this.CPU},RAM={this.RAM},USB={this.USB},KeyBoard={this.KeyBoard}");
        }
    }
}
