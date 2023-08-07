using Cor.CrossCuttingConcerns.Exceptions.Types;
using Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Type;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Cor.CrossCuttingConcerns.Exceptions.Handlers;

/// <summary>
/// gelecek hataları handler (işleyici) edıcek ter
/// </summary>
public abstract class ExceptionHandler
{
    //abstragın amacı 
    //gelecek olan hataları handler edıcek yer ımplemantasyon burada olmıycak o yuzden abstract yaprık 

    /// <summary>
    /// Gelen exception u kategorilere ayırıcak
    /// </summary>
    /// <param name="exception"></param>
    /// <returns></returns>
    public Task HandlerExceptionAsync(Exception exception) =>
        exception switch
        { //gelen hatanın turune gore handler etme uygulıycaz
            BusinessException businessException => HandlerException(businessException),
            ValidationException businessException => HandlerException(businessException),
            _ => HandlerException(exception)
        };

    protected abstract Task HandlerException(BusinessException businessException); //basına abstrac yazmamızın sebebi kalıtım alan adam bunu doldursun 
    protected abstract Task HandlerException(Exception exception);
    protected abstract Task HandlerException(ValidationException exception);
}
