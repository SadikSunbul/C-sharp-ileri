using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Type;


/// <summary>
/// fluent valıdatıonıcınbır hata sınıfı urettık 
/// </summary>
public class ValidationException : Exception
{//bırden fazla alanın hatası olabılır 
    public IEnumerable<ValidationExceptionModel> Errors { get; set; }

    public ValidationException()
       : base()
    {
        Errors = Array.Empty<ValidationExceptionModel>();
    }

    public ValidationException(string? message)
        : base(message)
    {
        Errors = Array.Empty<ValidationExceptionModel>();
    }

    public ValidationException(string? message, Exception? innerException)
        : base(message, innerException)
    {
        Errors = Array.Empty<ValidationExceptionModel>();
    }

    public ValidationException(IEnumerable<ValidationExceptionModel> errors)
        : base(BuildErrorMessage(errors))
    {
        Errors = errors;
    }
    /// <summary>
    /// Kısacası, bu kod parçası, bir hata koleksiyonunu alır, her hatayı biçimlendirir ve sonuç olarak bir dize döndürür. Bu dize, hatanın ayrıntılarını anlaşılır bir şekilde raporlar.
    /// </summary>
    /// <param name="errors"></param>
    /// <returns></returns>
    
    private static string BuildErrorMessage(IEnumerable<ValidationExceptionModel> errors)
    {//duzenleyıp hatayı sunuyoruz
        IEnumerable<string> arr = errors.Select(
            x => $"{Environment.NewLine} -- {x.Property}: {string.Join(Environment.NewLine, values: x.Errors ?? Array.Empty<string>())}"
        );
        return $"Validation failed: {string.Join(string.Empty, arr)}";
        /*
         errors: Bu, muhtemelen bir hata nesnesi koleksiyonu (IEnumerable) veya liste olmalıdır. Her bir hata nesnesi, bir özellik adı (x.Property) ve bu özelliğe ait hataların bir koleksiyonu (x.Errors) içerebilir.

Select: Bu, errors koleksiyonundaki her bir hata nesnesi için belirtilen işlemi gerçekleştirir. İşlem, her hatayı biçimlendirmek ve işlem sonucunu yeni bir koleksiyon (arr) olarak döndürmek gibi görünüyor.

x.Property: Her hatanın özellik adını temsil eder. Örneğin, hangi alanın hatalı olduğunu belirtir.

x.Errors ?? Array.Empty<string>(): Her hatanın hatalar koleksiyonunu (x.Errors) alır. Eğer hatalar koleksiyonu boşsa, Array.Empty<string>() ifadesi kullanılır. Bu, null referans hatası önlemek için yapılır.

string.Join(Environment.NewLine, values: x.Errors ...): Hatalar koleksiyonundaki her bir hatayı ayrı ayrı biçimlendirir ve bu hataları yeni satırlarla birleştirir.

arr: Sonuç olarak, her hatanın biçimlendirilmiş hali, arr koleksiyonunda toplanır.
         */
        /*
         Bu kısım, arr koleksiyonundaki her hatanın biçimlendirilmiş hali ile birlikte "Validation failed:" ifadesini içeren bir dize döndürür. Hatalar, yeni satırlarla ayrılmış şekilde dönecektir.
         */
    }
}

/// <summary>
/// validate sonucunda donucek olanı tıpı 
/// </summary>
public class ValidationExceptionModel 
{
    public string? Property { get; set; }
    //1 alanın 1den fazla hatası olabilir 
    public IEnumerable<string>? Errors { get; set; }
}