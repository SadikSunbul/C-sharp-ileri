using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cor.CrossCuttingConcerns.Exceptions.Types;

/// <summary>
/// kendi iş hata sınıfımızı olusturduk 
/// </summary>
public class BusinessException : Exception //bunun bir hata sınıfı oldugunu ımzaladık 
{
    //farklı ctor lar ile içine bılgılerı aldık 
    public BusinessException()
    {

    }

    public BusinessException(string? message) : base(message)
    {

    }

    public BusinessException(string? message, Exception? innerException) : base(message, innerException)
    {

    }
}
