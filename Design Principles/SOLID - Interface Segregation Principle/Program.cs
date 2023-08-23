
#region Interface Segregation Principle (Arayüz Ayrım) 

/*
 Interface Segregation Principle, bir nesnenin yapması
gereken her farklı davranış(lar)ın, o davranış(lar)a
odaklanmış özel interface'ler ile eşleşmesini öneren
prensiptir.

Böylece ihtiyaç olan davranışları temsil eden
interfaceller eşliğinde ilgili sınıflara kazandırabilir
ve hiçbir sınıfın kullanmadığı bir imzayı zorla
implement etmek zorunda kalmaksızın inşa sürecine
devam edebiliriz.
 */


#region Not Ideal Code

MyNamespace.SamsungPrinter printer = new();
printer.PrintDuplex();
#endregion
#region Ideal Code

SamsungPrinter printers = new();
printers.Fax();
#endregion

#region İdeal kod

interface IPrint
{
    void Print();
}
interface IScan
{
    void Scan();
}
interface IFax
{
    void Fax();
}
interface IPrintDuplex
{
    void PrintDuplex();
}
class HPPrinter : IPrint, IScan, IFax, IPrintDuplex
{
    public void Fax()
    {
        //... Fax işlemleri ...
    }

    public void Print()
    {
        //... Print işlemleri ...
    }

    public void PrintDuplex()
    {
        //... Print Duplex işlemleri ...
    }

    public void Scan()
    {
        //... Scan işlemleri ...
    }
}
class SamsungPrinter : IPrint, IFax
{
    public void Fax()
    {
        //... Fax işlemleri ...
    }

    public void Print()
    {
        //... Print işlemleri ...
    }
}
class LexmarkPrinter : IFax, IPrint, IScan
{
    public void Fax()
    {
        //... Fax işlemleri ...
    }

    public void Print()
    {
        //... Print işlemleri ...
    }

    public void Scan()
    {
        //... Scan işlemleri ...
    }
}

#endregion
#region İdeal olmayan kod
namespace MyNamespace
{
    interface IPrinter
    {
        void Print();
        void Scan();
        void Fax();
        void PrintDuplex();
    }

    class HPPrinter : IPrinter
    {
        public void Fax()
        {
            //... Fax işlemleri ...
        }

        public void Print()
        {
            //... Print işlemleri ...
        }

        public void PrintDuplex()
        {
            //... Print Duplex işlemleri ...
        }

        public void Scan()
        {
            //... Scan işlemleri ...
        }
    }
    class SamsungPrinter : IPrinter
    {
        public void Fax()
        {
            //... Fax işlemleri ...
        }

        public void Print()
        {
            //... Print işlemleri ...
        }

        public void PrintDuplex()
            => throw new NotSupportedException();

        public void Scan()
            => throw new NotSupportedException();
    }
    class LexmarkPrinter : IPrinter
    {
        public void Fax()
        {
            //... Fax işlemleri ...
        }

        public void Print()
        {
            //... Print işlemleri ...
        }

        public void PrintDuplex()
            => throw new NotSupportedException();

        public void Scan()
        {
            //... Scan işlemleri ...
        }
    }
}
#endregion



#endregion