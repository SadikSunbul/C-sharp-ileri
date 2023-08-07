using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Paging;

/// <summary>
/// Burası sayfalama hakkında bılgıler verırı itemleri vermez 
/// </summary>
public abstract class BasePageModel
{
    public int Size { get; set; }//sayfada kac data var
    public int Index { get; set; }//hangı sayfadayız
    public int Count { get; set; }//toplam kayıt sayısı 
    public int Pages { get; set; } //toplam kac sayfa var
    public bool HasPrevious => Index > 0;//yani ilk sauyfada değilse sayfanın öncesi var
    public bool HasNext => Index + 1 < Pages; //ındex e 1 eklemek lazım cunku syfa 1 den baslıyor 10 sayfa var ıse 9. sayfa 8.index tir mesela
}
