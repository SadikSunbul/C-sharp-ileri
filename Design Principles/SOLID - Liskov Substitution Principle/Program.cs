
#region SOLID - Liskov Substitution Principle 

/*
 Liskov Substitution Principle, ortak bir referanstan
türeyen nesnelerin hiçbir şeyi bozulmadan,
patlamadan, çatlamadan birbirleriyle
değiştirilebilmesi gerektiğini yani birbirlerinin yerine
geçebilmesi gerektiğini öneren bir prensiptir.
 */
#region Not Ideal Code

Cloud1 cloud = new AWS1();
cloud.MachineLearning();
cloud.Translate();

cloud = new Google1();
cloud.MachineLearning();
cloud.Translate();

cloud = new Azure1();
cloud.MachineLearning();
if (cloud is not Azure1)
{
    cloud.Translate();
}
#endregion

#region Ideal Code

Cloud cloudd = new AWS();
cloudd.MachineLearning();
(cloud as ITranslatable)?.Translate(); //cloud ITranslatable e dönebilirse oradan alıtıl dıysa tarsalate et 

cloudd = new Google();
cloudd.MachineLearning();
(cloudd as ITranslatable)?.Translate();

cloudd = new Azure();
cloudd.MachineLearning();
(cloudd as ITranslatable)?.Translate();
#endregion

#region Doğru tasarım 
abstract class Cloud
{
    public abstract void MachineLearning();
}
interface ITranslatable
{
    void Translate();
}
class AWS : Cloud, ITranslatable
{
    public void Translate()
       => Console.WriteLine("AWS Translate");
    override public void MachineLearning()
        => Console.WriteLine("AWS Machine Learning");
}

class Azure : Cloud
{
    override public void MachineLearning()
        => Console.WriteLine("Azure Machine Learning");
}

class Google : Cloud, ITranslatable
{
    public void Translate()
       => Console.WriteLine("Google Translate");

    override public void MachineLearning()
        => Console.WriteLine("Google Machine Learning");
}
#endregion

#region Hatalı Tasarım 
abstract class Cloud1
{
    public abstract void Translate();
    public abstract void MachineLearning();
}
class AWS1 : Cloud1
{
    override public void Translate()
        => Console.WriteLine("AWS Translate");
    override public void MachineLearning()
        => Console.WriteLine("AWS Machine Learning");
}

class Azure1 : Cloud1
{
    override public void Translate()
        => throw new NotImplementedException();

    override public void MachineLearning()
        => Console.WriteLine("Azure Machine Learning");
}

class Google1 : Cloud1
{
    override public void Translate()
        => Console.WriteLine("Google Translate");

    override public void MachineLearning()
        => Console.WriteLine("Google Machine Learning");
}
#endregion
#endregion