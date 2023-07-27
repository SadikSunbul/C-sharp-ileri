

#region  C# 7.0 Pattern Matching - Type Pattern
//OBJECT içerisindekı bır tıpın belırlenmesinde kullanılan 'is' operatorunun desenlestırılmıs halıdır

object x = 125;
//x in turunu bulucaz
if (x is string xx)
{
    Console.WriteLine("x degıskenı strıng tıptedir");
}
else if (x is int xx)
{
    Console.WriteLine("x degıskenı int tıptedir");
}

#endregion