using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Evliya_Celebi_Gezi_Rehberi2.Models
{
    public class GeziInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {


        protected override void Seed(DataContext context)
        {

            List<Bolge> Bolgeler = new List<Bolge>()
            {

                new Bolge{Adi="MARMARA BÖLGESİ"},
                new Bolge{Adi="EGE BÖLGESİ"},
                new Bolge{Adi="KARADENİZ  BÖLGESİ"},
                new Bolge{Adi="AKDENİZ  BÖLGESİ"},
                new Bolge{Adi="İÇ ANADOLU BÖLGESİ"},
                new Bolge{Adi="DOĞU ANADOLU BÖLGESİ"},
                new Bolge{Adi="GUNEY DOĞU ANADOLU BÖLGESİ"},


            };
            foreach (var item in Bolgeler)
            {
                context.Bolgeler.Add(item);
            }
            context.SaveChanges();


            List<Sehir> Sehirler = new List<Sehir>()
            {
                //BURADAN NEW SEHİR DİYEREK VE DEĞERLERİNİ GİREREK YENİ ŞEHİR EKLENEBİLİR

                new Sehir{Adi="İstanbul",aciklama="İstanbul, Türkiye'de yer alan şehir ve ülkenin 81 ilinden biri. Ülkenin en kalabalık, ekonomik, tarihi ve sosyo-kültürel açıdan en önemli şehridir.[6][7][8] Şehir, iktisadi büyüklük açısından dünyada 34., nüfus açısından belediye sınırları göz önüne alınarak yapılan sıralamaya göre Avrupa'da birinci, dünyada ise altıncı sırada yer almaktadır.[9][10]  İstanbul Türkiye'nin kuzeybatısında, Marmara kıyısı ve Boğaziçi boyunca, Haliç'i de çevreleyecek şekilde kurulmuştur. İstanbul kıtalararası bir şehir olup, Avrupa'daki bölümüne Avrupa Yakası veya Rumeli Yakası, Asya'daki bölümüne ise Anadolu Yakası veya Asya Yakası denir. Tarihte ilk olarak üç tarafı Marmara Denizi, Boğaziçi ve Haliç'in sardığı bir yarımada üzerinde kurulan İstanbul'un batıdaki sınırını İstanbul Surları oluşturmaktaydı. Gelişme ve büyüme sürecinde surların her seferinde daha batıya ilerletilerek inşa edilmesiyle 4 defa genişletilen şehrin[11] 39 ilçesi vardır. Sınırları içerisinde ise büyükşehir belediyesi ile birlikte toplam 40 belediye bulunmaktadır.  Dünyanın en eski şehirlerinden biri olan İstanbul, 330-395 yılları arasında Roma İmparatorluğu, 395-1204 yılları arasında Bizans İmparatorluğu, 1204-1261 yılları arasında Latin İmparatorluğu,1261-1453 yılları arasında tekrar Bizans İmparatorluğu ve son olarak 1453-1922 yılları arasında Osmanlı İmparatorluğu'na başkentlik yaptı.[12] Ayrıca İstanbul, Hilâfetin Osmanlı İmparatorluğu'na geçtiği 1517'den kaldırıldığı 1924'e kadar İslam dünyasının da merkezi oldu.[13]  Son yıllarda birbiri ardına ortaya çıkartılan arkeolojik bulgularla insanlık tarihine ilişkin önemli bilgiler elde edilmiştir. Yarımburgaz Mağarası'ndan çıkarılan taş aletlerle, ilkel insan izlerinin 400.000 yıl öncesine dayandığı ortaya çıkmıştır.[14][15][16][17] Anadolu Yakası'nda yürütülen kazı çalışmaları ve bunlara bağlı araştırmalar, şehirde tarım ve hayvancılığa dayalı ilk yerleşik insan topluluğunun MÖ 5500'lere tarihlenen Fikirtepe Kültürü olduğunu göstermiştir.[18] Bu arkeolojik bulgular yalnızca İstanbul'un değil, tüm Marmara Bölgesi'nin en eski insan izleridir.[18] İstanbul sınırları içinde kent bazında ilk yerleşimler ise Anadolu Yakası'nda Kalkedon; Avrupa Yakası'nda Byzantion'dur. Cumhuriyet dönemi öncesinde egemenliği altında olduğu devletlere yüzlerce yıl başkentlik yapan İstanbul, 13 Ekim 1923 tarihinde başkentin Ankara'ya taşınmasıyla bu özelliğini yitirmiş; ancak ülkenin ticaret, sanayi, ulaşım, turizm, eğitim, kültür ve sanat merkezi olma özelliğini sürdürmüştür.[19]",Resim="~/Content/img/kiz-kulesi.jpg",Anasayfa=true,BolgeId=1},
                new Sehir{Adi="Ankara",aciklama="Ankara, Türkiye'nin başkenti ve en kalabalık ikinci ilidir.[6] Nüfusu 2019 itibarıyla 5.639.076 kişidir. Bu nüfus; 25 ilçe ve bu ilçelere bağlı 1425 mahallede yaşamaktadır. İl genelinde nüfus yoğunluğu 215'tir. Coğrafi olarak Türkiye'nin merkezine yakın bir konumda bulunur ve Batı Karadeniz Bölgesi'nde kalan kuzey kesimleri hariç, büyük bölümü İç Anadolu Bölgesi'nde yer alır. Yüzölçümü olarak ülkenin üçüncü büyük ilidir. Bolu, Çankırı, Kırıkkale, Kırşehir, Aksaray, Konya ve Eskişehir illeri ile çevrilidir.  Ankara'nın başkent ilan edilmesinin ardından (13 Ekim 1923) şehir hızla gelişmiş ve Türkiye'nin ikinci en kalabalık ili olmuştur. Türkiye Cumhuriyeti'nin ilk yıllarında ekonomisi tarım ve hayvancılığa dayanan ilin topraklarının yarısı hâlâ tarım amaçlı kullanılmaktadır. Ekonomik etkinlik büyük oranda ticaret ve sanayiye dayalıdır. Tarım ve hayvancılığın ağırlığı ise giderek azalmaktadır. Ankara ve civarındaki gerek kamu sektörü gerek özel sektör yatırımları, başka illerden büyük bir nüfus göçünü teşvik etmiştir. Cumhuriyetin kuruluşundan günümüze, nüfusu ülke nüfusunun iki katı hızda artmıştır. Nüfusun yaklaşık dörtte üçü hizmet sektörü olarak tanımlanabilecek memuriyet, ulaşım, haberleşme ve ticaret benzeri işlerde, dörtte biri sanayide, %2'si ise tarım alanında çalışır. Sanayi, özellikle tekstil, gıda ve inşaat sektörlerinde yoğunlaşmıştır. Günümüzde ise en çok savunma, metal ve motor sektörlerinde yatırım yapılmaktadır. Türkiye'nin en çok sayıda üniversiteye sahip ili olan Ankara'da ayrıca, üniversite diplomalı kişi oranı ülke ortalamasının iki katıdır. Bu eğitimli nüfus, teknoloji ağırlıklı yatırımların gereksinim duyduğu iş gücünü oluşturur. Ankara'dan otoyollar, demir yolu ve hava yoluyla Türkiye'nin diğer şehirlerine ulaşılır.",Resim="~/Content/img/ankara.jpg",Anasayfa=true,BolgeId=5},
                new Sehir{Adi="Konya",aciklama="Konya, Türkiye'nin yüzölçümü bakımından en büyük ili ve en kalabalık yedinci şehridir. 31 ilçeden oluşur. Konya İl Nüfusu: 2.232.374'dür. (2019) [3] Trafik plaka numarası 42'dir.[4] 1875'te kurulan Konya Belediyesi, 1987'de çıkarılan 3399 sayılı yasa gereğince büyükşehir statüsüne kavuşmuş olup 1989'dan beri belediye hizmetleri bu statüye göre yürütülmektedir. 2014'te 6360 sayılı kanun ile büyükşehir belediyesinin sınırları il mülki sınırları oldu.  Ekonomik açıdan Türkiye'nin gelişmiş kentlerinden biri olan Konya doğal ve tarihsel zenginlikleriyle de önem taşır. Dünyanın en eski yerleşimlerinden biri olan Çatalhöyük, 2012 yılında UNESCO Dünya Miras Listesi'ne alınmıştır. Şehir Anadolu Selçukluları’nın ve Karamanoğulları’nın başkentliğini yapmıştır.Türkiye'nin en önemli sanayi kentlerindendir. Anadolu Kaplanları'ndandır. Şehrin futbol takımı İttifak Holding Konyaspor'dur. Yöresel yemekleri Etliekmek, Bamya Çorbası, Mevlana böreği,Yağ Somunu, Tiriti, Konya Pilavı, Sac arası ve Fırın kebabı'dır. Konya’nın simgeleri arasında Mevlana Müzesi (Kubbe-i Hadrâ), çift başlı kartal'dır.",Resim="~/Content/img/konya.jpg",Anasayfa=true,BolgeId=5},
                new Sehir{Adi="Kütahya",aciklama="Kütahya (Latince: Cotyaeum), Ege Bölgesi'nde yer alan 272.367 nüfuslu (2019 tahmini)[1] Kütahya ilinin merkezi şehirdir. Kütahya bölgesi, kuzey ve batıdaki yüksek dağ sırtlarında doruğa ulaşan tarım arazileri ile geniş bir yamaç alanına sahiptir. Kentin Yunanca adı Kotyaion, Roma dönemindeki adı ise Cotyaeum'dur[2].  Eski kaynaklara, sikke ve yazıtlara göre Kütahya’nın antik dönemdeki adı “Kotiaeion” (Cotiaeion)'dur[3]. Ünlü Antik Çağ coğrafyacısı Strabon bu adın, “Kotys’in Kenti” anlamına geldiğini belirtmektedir. Kotys, Trakya’da yaşayan Odrisler’den olup, Romalılar’ın MS 38'de Anadolu’ya gönderdiği bir komutanın adıdır. Kütahya Arkeoloji Müzesi’nde bulunan bir sikkede bu ad “Koti” olarak geçmektedir. Kütahya adı, eskisine benzetilerek Türkler tarafından verilmiştir[4]. Şehrin nüfusu 2013 yılına göre 249.558'dir.1927'de 17.000 olan nüfusu, 1990'da 131.000'e, 2000'de 167.000'e, 2008'de 213.000'e 2010'da 235.000'e çıkmış, 2014'te 228.000'e gerilemiştir. Kent'in günümüzdeki belli başlı görülmesi gerekli yerleri Kütahya Kalesi, Cumhuriyet Caddesi (Yeni adı Sevgi Yolu) kentin merkezinde bulunan simgesi haline gelmiş çiniden yapılmış olan Vazo ve tarihi Germiyan Sokağı, Saat Kulesi, Zafertepe Anıtı, Tarihi Hükûmet Konağı (şu an Adliye olarak kullanılmaktadır), Frig Vadileridir.",Resim="/Content/img/kutahya.jpg",Anasayfa=true,BolgeId=2},
                new Sehir{Adi="Adana",aciklama="Adana, Türkiye'nin bir ili ve en kalabalık altıncı şehridir. 2019 yılı verilerine göre 2.237.940 nüfusa sahiptir. İlin yüzölçümü 13.844 km2'dir. İlde km2'ye 160 kişi düşmektedir. (Bu sayı en çok Seyhan ilçesinde 1787 kişidir.)  01.02.2018 TÜİK verilerine göre 4'ü anakent ilçesi (Seyhan, Yüreğir, Çukurova, Sarıçam) olmak üzere toplam 15 İlçesi ve belediyesi vardır. Bu ilçelerde 831 mahalle bulunmaktadır.  Türkiye'deki altıncı büyük metropolitan alan olup ülkenin önde gelen bir tarım, ticaret ve kültür merkezidir. Türkiye'deki aden zengini 4. bölge olan Adana; krom, demir, manganez, kurşun ve çinko yatakları açısından önem taşımaktadır.  Adana'nın merkezi; Mersin, Adana, Osmaniye ve Hatay illerini kapsayan coğrafi, ekonomik ve kültürel bir bölge olan Çukurova'nın merkezinde bulunur. Yaklaşık 5,62 milyon insana ev sahipliği yapan bölgenin büyük bir bölümü, tarıma oldukça elverişli, geniş ve düz bir arazidir.",Resim="~/Content/img/adana.jpg",Anasayfa=true,BolgeId=4},
                new Sehir{Adi="Bursa",aciklama="Bursa, Türkiye'nin bir ili ve en kalabalık dördüncü şehri. 2019 itibarıyla 3.056.120[2] nüfusa sahiptir. 2016 Dünya Yaşanabilir Şehirler sıralamasında Dünya'da 28[4]. Türkiye'de 1. sırada yer almaktadır. Marmara Bölgesinin Güney Marmara bölümünde, 40° batı boylam ve 29° kuzey enlem daireleri arasında yer alır. Eski adı Hüdavendigâr'dır. Kuzeyinde Marmara Denizi ve Yalova, kuzeydoğuda Kocaeli ve Sakarya, doğuda Bilecik, güneyde Kütahya ve batıda Balıkesir illeri ile çevrilidir.  Ekonomik açıdan Türkiye'nin en gelişmiş kentlerinden biri olan Bursa doğal ve tarihsel zenginlikleriyle de önem taşır. Bursa'da en çok Osmanlı İmparatorluğu'nun kuruluş dönemine ait tarihî eserlerin bulunmasının sebebi ise, Bursa'nın Osmanlı Devleti'nin ilk başkenti olmasıdır. Bursa alışveriş merkezleri, parkları, müzeleri ve çarşısıyla bölgede öne çıkar. Ayrıca Bursa Marmara bölgesinin İstanbul'dan sonra gelen ikinci büyük şehridir. Türkiye'nin en önemli birkaç sanayi kentinden biridir. Şehir İstanbul'dan sonra en büyük ikinci ihracatı gerçekleştirmektedir.",Resim="~/Content/img/kayak.jpg",Anasayfa=true,BolgeId=1},
                new Sehir{Adi="Nevşehir",aciklama="Kent, Orta Çağ ve Yeni Çağ'da, Seandos; Nissa ve Muşkara adıyla anılıyordu. Anadolu, Büyük Selçuklu Devleti'nin elindeyken eski adı Nissa'nın yerinde Muşkara adında bir köy vardı. Muşkara sağlam yapılı anlamındadır. 18 evlik küçük bir köy olan Muşkara, Ürgüp'e bağlıydı.  Tarihçi Charles Texier'e göre; 12. yüzyıl sonlarına doğru, yani Selçuklular zamanında, Nissa şehri halkı yavaş yavaş şehirden ayrılarak, başka bir yere göç etmişlerdir. Çevre ile ilgili bilgi veren tarihçiler, bu yeni göç yerinin Muşkara olduğunu yazarlar.  Osmanlılar döneminde ise Muşkara yerine Nevşehir kullanılmaya başlandı. IV. Mehmet'in oğlu Şehzade III. Ahmet'in sır katibi, Muşkaralı İbrahim, Nevşehirli Damat İbrahim Paşa olarak sadrazamlığa getirildiğinde doğduğu kent olan Muşkara'da büyük bayındırlık hareketine girişti. İmaretler, camiler, medreseler, hamam ve çeşmeler yaptırdı. Muşkara adını değiştirerek, kente Yenişehir anlamına gelen Nevşehir adını verdi.",Resim="~/Content/img/peri2.jpg",Anasayfa=true,BolgeId=5},
            };

            foreach (var item in Sehirler)
            {
                context.Sehirler.Add(item);
            }
            context.SaveChanges();

            List<Dogalmekan> Dogalmekanlar = new List<Dogalmekan>()
            {
                //BURADAN NEW DOGALMEKAN DİYEREK VE DEĞERLERİNİ GİREREK YENİ DOGALMEKAN EKLENEBİLİR
                //(EKLERKEN SEHİRID'SİNİ DOĞRU VERMEYİ UNUTMA ÖRNEĞİN ANKARANIN ID'Sİ 2 ANKARAYA DOGAL MEKAN EKLENİRKEN SEHİRID'Sİ 2 OLMALI!!)

                new Dogalmekan{Adi="BELGRAD ORMANI",Aciklama="İstanbul'un geriye kalan en önemli yeşil alanlarından biri Belgrad Ormanı. Doğal oluşum olması dolayısıyla datam bir hazine niteliğinde bu şehirde yaşayanlar için. Şehrin köşesinde gizli kalmış yeşil bir dünya burası.Mesire yerleri, su kemerleri, doğal yaşamı ve huzurlu ortamı ile Belgrad Ormanı, İstanbulluların nefes almakiçin uğradıkları kaçış noktalarından biri.",SehirId=1,Image="~/Content/img/BELGRAD-ORMANI.jpg"}
            };

            foreach (var item in Dogalmekanlar)
            {
                context.Dogalmekanlar.Add(item);
            }

            List<Tarihimekan> tarihimekans = new List<Tarihimekan>()
            {
                
                //BURADAN NEW TARİHİMEKAN DİYEREK VE DEĞERLERİNİ GİREREK YENİ TARİHİMEKAN EKLENEBİLİR
                //(EKLERKEN SEHİRID'SİNİ DOĞRU VERMEYİ UNUTMA ÖRNEĞİN ANKARANIN ID'Sİ 2 ANKARAYA TARİHİMEKAN EKLENİRKEN SEHİRID'Sİ 2 OLMALI!!)
                new Tarihimekan{Adi="AYASOFYA CAMİİ",Aciklama="Mimar Sinan’ın el emeği göz nuru olan yapıt, yaklaşık 15 yüzyıldır ayakta duruyor. Ayasofya’nın en eski restorasyonun Mimar Sinan’a ait olması yapının bugüne dek ayakta kalmasının en büyük sebebi anlayacağınız.İkinci bir sebep olarak ise, yapının temelinin tamamen suyun içinde oturması olarak gösterilir. Su, depremlerinetkisini bir miktar azalttığından yapıt İstanbul’daki depremlere karşı koyabilmiş.",SehirId=1,Image="~/Content/img/AYASOFYA-CAMII.jpg"},
            };

            foreach (var item in tarihimekans)
            {
                context.Tarihimekanlar.Add(item);
            }

            List<Eglencemekan> eglencemekans = new List<Eglencemekan>()
            {
                
                //BURADAN NEW EGLENCEMEKAN DİYEREK VE DEĞERLERİNİ GİREREK YENİ EGLENCEMEKAN EKLENEBİLİR
                //(EKLERKEN SEHİRID'SİNİ DOĞRU VERMEYİ UNUTMA ÖRNEĞİN ANKARANIN ID'Sİ 2 ANKARAYA EGLENCEMEKAN EKLENİRKEN SEHİRID'Sİ 2 OLMALI!!)
                new Eglencemekan{Adi="KLEIN",Aciklama="21 Ekim günü İrlandalı Stee Downes’un canlı performansıyla açılan Klein’ın mekanı, 70’li yıllarda bir sinema salonu olarak kullanılıyormuş. Sahipleri İsmail Alper ve Burak Yön’ü belki ismen tanımasanız bile, muhakkak diğer mekanlarında, Love, Rehab veya Raw'da bulunmuşsunuzdur. Elektronik müziği nu disco’dan tech house’a geniş bir yelpazede dinleyebileceğiniz bu mekanın müzik koordinatörlüğünü, yine festivallerden, kulüplerden yahut radyolardan tanıyabileceğiniz Orkun Bozdemir üstlenmekte. Peki kimleri dinlemek mümkün? Geçtiğimiz aylarda Dearhead, Fuchs, Mehmet Koryürek, Yakuza, Oceanvs Orientails gibi pek çok önemli ve yerli isim canlı performanslarını gerçekleştirdi; Brame & Hamo, Daniel Solar, Jonas Rathsman, Tender Games, Isaac Tichauer gibi bir takım mühim kişiler Klein’ın kabinini ziyaret etti. Mekanın mayıs programı da pek mütevazi değil. Geçtiğimiz günlerde mekanı Art Department ziyaret etti. Önümüzdeki günlerde ise Thabo Getsome, John Digweed, Jackmaster gibi isimler, Klein aracılığıyla İstanbullu dinleyiciyle buluşacak. Ayın 28'inde ise mekanın sezon kapanış partisi var. Elbette yurt dışından DJ getirmek dünyanın en masrafsız işi sayılmaz, Klein için de ‘her bütçeye uygun’ gibi bir laf etmek pek mümkün olmayacak, zira mekana giriş ücreti 45 TL.",SehirId=1,Image="~/Content/img/KLEIN.jpg"}

            };

            foreach (var item in eglencemekans)
            {
                context.Eglencemekanlar.Add(item);
            }

            context.SaveChanges();
            base.Seed(context);

        }
    }
}