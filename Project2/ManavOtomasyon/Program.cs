using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavOtomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********Hale Hoşgeldiniz**********");
            int toplam = 0;
            ArrayList meyve = new ArrayList();
            meyve.Add("Kiraz");
            meyve.Add("Dut");
            meyve.Add("Karpuz");
            meyve.Add("Elma");
            meyve.Add("Çilek");

            ArrayList sebze = new ArrayList() { "Soğan", "Domates", "Fasulye", "Ispanak", "Patates" };
            ArrayList mkilo = new ArrayList();
            ArrayList skilo = new ArrayList();
            ArrayList manavm = new ArrayList();
            ArrayList manavs = new ArrayList();
            ArrayList manavlist = new ArrayList();

            while (true)
            {
                Console.WriteLine("Meyve için M,Sebze için S'ye basınız.");
                char secim = Convert.ToChar(Console.ReadLine());

                switch (secim)
                {
                    case 'm':
                    case 'M':
                        for (int i = 0; i < meyve.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}-" + meyve[i]);

                        }
                        Console.WriteLine("Hangi ürünü istediğinizi yazınız.");
                        string urun = Console.ReadLine().ToLower();

                        if (urun == "kiraz")
                        {
                            Console.WriteLine("Kaç kilo istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (manavm.IndexOf("kiraz") >= 0)
                            {
                                toplam = (int)mkilo[manavm.IndexOf("kiraz")];

                                mkilo[manavm.IndexOf("kiraz")] = toplam + kilo;

                            }
                            else
                            {
                                manavm.Add("kiraz");
                                mkilo.Add(kilo);

                            }


                        }

                        else if (urun == "dut")
                        {
                            Console.WriteLine("Kaç kilo istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (manavm.IndexOf("dut") >= 0)
                            {
                                toplam = (int)mkilo[manavm.IndexOf("dut")];

                                mkilo[manavm.IndexOf("dut")] = toplam + kilo;

                            }
                            else
                            {
                                manavm.Add("dut");
                                mkilo.Add(kilo);

                            }


                        }
                        else if (urun == "karpuz")
                        {
                            Console.WriteLine("Kaç kilo istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (manavm.IndexOf("karpuz") >= 0)
                            {
                                toplam = (int)mkilo[manavm.IndexOf("karpuz")];

                                mkilo[manavm.IndexOf("karpuz")] = toplam + kilo;

                            }
                            else
                            {
                                manavm.Add("karpuz");
                                mkilo.Add(kilo);

                            }
                        }
                        else if (urun == "elma")
                        {
                            Console.WriteLine("Kaç kilo istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (manavm.IndexOf("elma") >= 0)
                            {
                                toplam = (int)mkilo[manavm.IndexOf("elma")];

                                mkilo[manavm.IndexOf("elma")] = toplam + kilo;

                            }
                            else
                            {
                                manavm.Add("elma");
                                mkilo.Add(kilo);

                            }

                        }


                        else if (urun == "çilek")
                        {
                            Console.WriteLine("Kaç kilo istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (manavm.IndexOf("çilek") >= 0)
                            {
                                toplam = (int)mkilo[manavm.IndexOf("çilek")];

                                mkilo[manavm.IndexOf("çilek")] = toplam + kilo;

                            }
                            else
                            {
                                manavm.Add("çilek");
                                mkilo.Add(kilo);

                            }


                        }

                        else
                        {
                            Console.WriteLine("Yanlış ürün yazdınız.Tekrar deneyin...");
                            continue;
                        }

                        Console.WriteLine("Başka bir arzunuz var mı? Evet ise E,Hayır ise H'ye basınız.");
                        string secim5 = Console.ReadLine().ToUpper();
                        if (secim5 == "E")
                        {
                            continue;
                        }
                        else if (secim5 == "H")
                        {
                         
                        }

                        else
                        {
                            Console.WriteLine("Hatalı seçim.Tekrar deneyin..");
                            break;
                        }
                        break;


                    case 's':
                    case 'S':

                        for (int i = 0; i < sebze.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}-" + sebze[i]);

                        }
                        Console.WriteLine("Hangi ürünü istersiniz?");
                        string secim3 = Console.ReadLine().ToLower();

                        if (secim3 == "soğan")
                        {
                            Console.WriteLine("Kaç kilo almak istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            if (manavs.IndexOf("soğan") >= 0)
                            {
                                toplam = (int)skilo[manavs.IndexOf("soğan")];
                                skilo[manavs.IndexOf("soğan")] = kilo + toplam;
                            }
                            else
                            {
                                manavs.Add("soğan");
                                skilo.Add(kilo);

                            }
                        }
                        else if (secim3 == "domates")
                        {
                            Console.WriteLine("Kaç kilo almak istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (manavs.IndexOf("domates") >= 0)
                            {
                                toplam = (int)skilo[manavs.IndexOf("domates")];
                                skilo[manavs.IndexOf("domates")] = kilo + toplam;
                            }
                            else
                            {
                                manavs.Add("domates");
                                skilo.Add(kilo);

                            }

                        }
                        else if (secim3 == "fasulye")
                        {
                            Console.WriteLine("Kaç kilo almak istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (manavs.IndexOf("fasulye") >= 0)
                            {
                                toplam = (int)skilo[manavs.IndexOf("fasulye")];
                                skilo[manavs.IndexOf("fasulye")] = kilo + toplam;
                            }
                            else
                            {
                                manavs.Add("fasulye");
                                skilo.Add(kilo);

                            }
                        }
                        else if (secim3 == "ıspanak")
                        {

                            Console.WriteLine("Kaç kilo almak istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (manavs.IndexOf("ıspanak") >= 0)
                            {
                                toplam = (int)skilo[manavs.IndexOf("ıspanak")];
                                skilo[manavs.IndexOf("ıspanak")] = kilo + toplam;
                            }
                            else
                            {
                                manavs.Add("ıspanak");
                                skilo.Add(kilo);

                            }
                        }

                        else if (secim3 == "patates")
                        {
                            Console.WriteLine("Kaç kilo almak istersiniz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            if (manavs.IndexOf("patates") >= 0)
                            {
                                toplam = (int)skilo[manavs.IndexOf("patates")];
                                skilo[manavs.IndexOf("patates")] = kilo + toplam;
                            }
                            else
                            {
                                manavs.Add("patates");
                                skilo.Add(kilo);

                            }
                        }
                        else
                        {
                            Console.WriteLine("Yanlış ürün seçimi.Tekrar deneyiniz.");
                            continue;
                        }

                        Console.WriteLine("Başka bir arzunuz var mı? Evet ise E,Hayır ise H'ye basınız.");
                        string secim4 = Console.ReadLine().ToUpper();
                        if (secim4 == "E")
                        {
                            continue;
                        }
                        else if (secim4 == "H")
                        {
                            

                        }

                        else
                        {
                            Console.WriteLine("Hatalı seçim.Tekrar deneyin..");
                            continue;
                        }

                        break;

                    default:
                        Console.WriteLine("Hatalı giriş yaptınız.Tekrar Deneyiniz...");
                        continue;

                }
                break;
            }


            Console.WriteLine("*********Manava Hoşgeldiniz*********");
            while (true)
            {
                Console.WriteLine("Meyve için M ,sebze için S'ye basınız..");
                string islem = Console.ReadLine().ToUpper();
                if (islem == "M")
                {
                    for (int i = 0; i < manavm.Count; i++)
                    {
                        Console.WriteLine(manavm[i]);
                    }
                    while (true)
                    {
                        Console.WriteLine("Hangi ürünü istersiniz?");
                        string urun = Console.ReadLine().ToLower();

                        if (manavm.IndexOf(urun) >= 0)
                        {
                            Console.WriteLine("Kaç kilo istersiniz?");
                            int kiloM = Convert.ToInt32(Console.ReadLine());

                            if ((int)mkilo[manavm.IndexOf(urun)] >= kiloM)
                            {
                                if (manavlist.IndexOf(urun) >= 0)
                                {
                                    toplam = (int)mkilo[manavlist.IndexOf(urun)];

                                    mkilo[manavlist.IndexOf(urun)] = toplam + kiloM;

                                }
                                else
                                {

                                    manavlist.Add(urun);
                                    Console.WriteLine("işlem Başarılı");

                                }



                            }
                            else if ((int)mkilo[manavm.IndexOf(urun)] < kiloM)
                            {
                                Console.WriteLine("istediğiniz kiloda ürün elimizde bulunmamaktadır...");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Elimizde böyle bir ürün bulunmamaktadır.Tekrar Deneyin...");

                        }
                        break;
                    }

                }

                else if (islem == "S")
                {
                    for (int i = 0; i < manavs.Count; i++)
                    {
                        Console.WriteLine(manavs[i]);
                    }
                    while (true)
                    {
                        Console.WriteLine("Hangi ürünü istersiniz?");
                        string urun = Console.ReadLine().ToLower();

                        if (manavs.IndexOf(urun) >= 0)
                        {
                            Console.WriteLine("Kaç kilo istersiniz?");
                            int kiloM = Convert.ToInt32(Console.ReadLine());

                            if ((int)skilo[manavs.IndexOf(urun)] >= kiloM)
                            {

                                if (manavlist.IndexOf(urun) >= 0)
                                {
                                    toplam = (int)skilo[manavlist.IndexOf(urun)];

                                    skilo[manavlist.IndexOf(urun)] = toplam + kiloM;

                                }
                                else
                                {

                                    manavlist.Add(urun);
                                    Console.WriteLine("işlem Başarılı");

                                }

                            }
                            else if ((int)skilo[manavs.IndexOf(urun)] < kiloM)
                            {
                                Console.WriteLine("istediğiniz kiloda ürün elimizde bulunmamaktadır...");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Elimizde böyle bir ürün bulunmamaktadır.Tekrar Deneyin...");

                        }
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Hatalı işlem girişi.Tekrar deneyin...");
                }
            
            Console.WriteLine("Başka bir arzunuz var mı? Evet ise E,Hayır ise H'ye basınız.");
            string secim4 = Console.ReadLine().ToUpper();
            if (secim4 == "E")
            {
                continue;
            }
            else if (secim4 == "H")
            {
                Console.WriteLine("**********Müşteri Listesi*******");
                for (int i = 0; i < manavlist.Count; i++)
                {
                    Console.WriteLine($"{i + 1}-" + manavlist[i]);

                }
                    Console.WriteLine("Sistemden çıkış yapmak için 1'e basınız.");
                    int cikis = Convert.ToInt32(Console.ReadLine());

                    if (cikis == 1)
                    {
                        Environment.Exit(0);
                    }
                    
            }

            else
            {
                Console.WriteLine("Hatalı seçim.Tekrar deneyin..");

            }

        }

            
        }
    }
}

