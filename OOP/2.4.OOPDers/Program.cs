using System;
using System.Collections.Generic;

namespace _2._4.OOPDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstraction
            MyClass my = new();
            IInterface ınterface = my;
            ınterface.x(); //cok fazla metot olabır ıcerısınde bunları bulmak efektıf olarak kullanmak ıcınde ınterface kullanılır

            Userservice userservice = new Userservice();
            IUserValidateService validateService=userservice;
            validateService.ValidateUser(new UserInfo());


        }
    }

    #region  Abstraction (soyutlama) Kavramı Nedir?
    /*
         Abstraction ,bir sınıfın meberlarından ıhtıyac noktasında alaklı olanları gosterıp alakasız olmayanları gostermemek demek oluyor

        1 sınıf 1 den fazla interface yı ımplamente edebılır 
    interface = Sözleşme  bi taraftan turgıbıde davranır
    */

    //Abstractin belirli bir sınıfın belirli bir davranişa sahip olduğunun garantisini sağlamaktadır

    //Abstractionın amacı gelistiriciden bır sınıda karsın olabılecek gereksız ayrıntıları gızleyerek karmasıklıgın ustesınden gelmektedir

    //o sınıftan uretılmıs bır ınstence ı kullanırken o ınstance ın sadece ne yapabılecegını gostermek lakın nasıl yapabılecegıhakkında bılgı vermemektir

    interface IInterface
    {
        void x();
    }
    class MyClass : IInterface
    {
        public void x()
        {
            throw new NotImplementedException();
        }
        public void y()
        {

        }
    }

    interface  IUserValidateService
    {
        bool ValidateUser(UserInfo userInfo);
    }

    class Userservice:IUserValidateService
    {
        public void CreateUser(UserInfo userInfo)
        {

        }
        public void RemoveUser(int userId)
        {

        }

        public List<User> user { get; set; }

        public bool ValidateUser(UserInfo userInfo)
        {
            return true;
        }
    }

    class UserInfo
    {

    }

    class User
    {

    }



    #endregion
}
