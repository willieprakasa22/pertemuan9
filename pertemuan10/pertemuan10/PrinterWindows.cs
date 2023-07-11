using System;
namespace pertemuan10
{
	public class PrinterWindows
	{
		public string name { get; set; }
		public string dimention { get; set; }

        public PrinterWindows(string name, string dimention)  
        {
            this.name = name;
            this.dimention = dimention;
        }

        public virtual void show()
		{
			Console.WriteLine("{0} display dimention : {1}", this.name, this.dimention);
		}


		public virtual void print()
		{
			Console.WriteLine("{0} printer printing....", this.name);

        }
	}


	public class Epson : PrinterWindows
	{
        public Epson(string name, string dimention) : base(name, dimention)
        {
            this.name = name;
            this.dimention = dimention;
        }

        public override void show()
        {
            Console.WriteLine("{0} display dimention : {1}", this.name, this.dimention);
        }


        public override void print()
        {
            Console.WriteLine("{0} printer printing....", this.name);

        }
 
    }


    public class Canon : PrinterWindows
    {
        public Canon(string name, string dimention) : base(name, dimention)
        {
            this.name = name;
            this.dimention = dimention;
        }

        public override void show()
        {
            Console.WriteLine("{0} display dimention : {1}", this.name, this.dimention);
        }


        public override void print()
        {
            Console.WriteLine("{0} printer printing....", this.name);

        }

    }



    public class Lasetjet : PrinterWindows
    {
        public Lasetjet(string name, string dimention) : base(name, dimention)
        {
            this.name = name;
            this.dimention = dimention;
        }

        public override void show()
        {
            Console.WriteLine("{0} display dimention : {1}", this.name, this.dimention);
        }


        public override void print()
        {
            Console.WriteLine("{0} printer printing....", this.name);

        }

    }
}

