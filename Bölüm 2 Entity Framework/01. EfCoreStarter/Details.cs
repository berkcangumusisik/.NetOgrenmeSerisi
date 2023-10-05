namespace _01._EfCoreStarter
{
    public class Details
    {

    }
}


/**
 * ORM (Object Relational Mapping - Nesne İlişkisel Eşleme)
 * Yazılım uygulamalarında veriler fiziksel olarak veritabanında tutulur.
 * Haliyle yazılım ile veritabanı arasında sürekli bir bağlantı üzerinden iletişim sağlanmalıdır.
 * Yazılım dış dünyadan ekde ettiği verileri veritabanına işleyebilsin ya da veritabanından aldığı verileri dış dünyaya aktarabilsin.
 * Yazılım ile veritabanı arasında verisel trafik gerçekleşir.
 * Yazılım veritabanının anlayacağı dilden sorgular gönderir ve veritabanı da yazılımın anlayacağı dilden cevaplar verir. Bu sorgular SQL sorgularıdır.
 * SELECT : Veritabanından veri çekmek için kullanılır.
 * INSERT , UPDATE , DELETE : Veritabanına veri eklemek , güncellemek ve silmek için kullanılır.
 
SQL Yazmanın Dezavantajları
- Kodun kirlenmesine sebep olur.
- Geliştirme ve bakım maliyeti yüksek kod inşasına sebep olur.
- Veritabanı bağımlılığı oluşturur. En büyük dezavantajı budur.
- Kompleks sorgular manuel bir şekilde oluştulması gerekir.
- Bağımlılık oluşturduğu için veritabanı değişikliklerinde kodda değişiklik yapılması gerekir.
- Kodu veritabanından olan değişikliğe uygun bir şekilde güncellemek gerekir.
- Kodu aşırı derecede veritabanına bağımlı hale getirir.


ORM Avantajları
- Veritabanı bağımlılığını ortadan kaldırır.
- Kullanılan veritabanı değişse bile kodda değişiklik yapılmasına gerek kalmaz.
- SQL yeteneklerine ihtiyaç duymadan veritabanı işlemleri yapılabilir.
- Kodun okunabilirliği artar.

*/