using System;

namespace TheSuperComputer
{
    class Computer
    {
        private Monitor monitor;
        private Printer printer;
        private Processor processor;
        private Ram ram;
        private Vga vga;

        private Computer(Builder builder)
        {
            this.monitor = builder.monitor;
            this.processor = builder.processor;
            this.printer = builder.printer;
            this.ram = builder.ram;
            this.vga = builder.vga;
        }

        public override string ToString()
        {
            return $"monitor spec : {this.monitor}\n" +
                $"Processor spec : {this.processor}\n" +
                $"Printer spec : {this.printer}\n" +
                $"VGA spec : {this.vga}\n" +
                $"RAM spec : {this.ram}\n";
        }

        public class Builder
        {
            public Monitor monitor;
            public Printer printer;
            public Processor processor;
            public Vga vga;
            public Ram ram;

            public Builder(Ram ram, Vga vga, Processor processor)
            {
                this.ram = ram;
                this.vga = vga;
                this.processor = processor;
            }

            public Builder withMonitor(Monitor monitor)
            {
                this.monitor = monitor;
                return this;
            }

            public Computer build()
            {
                return new Computer(this);
            }
        }
    }
}
