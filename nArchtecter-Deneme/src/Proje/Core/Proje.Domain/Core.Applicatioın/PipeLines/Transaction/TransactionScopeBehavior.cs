using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Proje.Domain.Core.Applicatioın.PipeLines.Transaction;

public class TransactionScopeBehavior<TRequest, TRespons> : IPipelineBehavior<TRequest, TRespons> where TRequest : IRequest<TRespons>, ITransactionalRequest
{
    //Şimdi burada bır kısıtlama getırdık dedıkkı sınıf hem IRequest olmalı hemde ITransactionalRequest olmalıdır aksı takdırde burası uygulanmaz
    //yukardakılere uyan var ıse bu alttakı handler calsıcaktır
    public async Task<TRespons> Handle(TRequest request, RequestHandlerDelegate<TRespons> next, CancellationToken cancellationToken)
    {
        using TransactionScope transactionScope =new (TransactionScopeAsyncFlowOption.Enabled); //asenkronu enabeld(etkınlestırıyor) edıyoruz 
        TRespons respons; //respons nesnesı olusturduk 
        try
        {
            respons = await next(); //metodu calıstır
            transactionScope.Complete(); //yaz bunları basarılı
        }
        catch (Exception)
        {

            transactionScope.Dispose(); //basarısız bunları ıptal et 
            throw;
        }
        return respons;
        
    }
}
