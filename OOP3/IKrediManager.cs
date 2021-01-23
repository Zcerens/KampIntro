using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Okunurluğu artırmak için interfaceleri I ile başlatırız. ki interface oldugunu anlayalım.
    interface IKrediManager //interface şablon görevi görüyor
    {
        void Hesapla(); //bizim için bir interface
        void BiseyYap(); //Birden fazla operayon alabiliyor.(hesapla ve biseyyap)
        
    }

    //Interface i birbirinin alternatifi olan ama kod içerikleri farklı olanlar için kullanırız
    // loglama = bir sistemde olan hareketleri döktüğümüz bir harekettir. (banka hesabımda bir hareket olduğunda sms gelmesi)
}
