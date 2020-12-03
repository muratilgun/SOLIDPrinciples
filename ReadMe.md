## Single Responsibilty Principle

- Bir sınıf, method sadece bir işi yapmalıdır.

- Bir sınıfın değişmesi için sadece bir nedeni olmalıdır. Yani bir sınıfın yanlızca bir işi olmalıdır.

- **Örnek1:**  İşe yeni başlamış personelin özlük bilgilerinin sisteme kaydedilmesi, bu işlemin loglarının tutulması ve ilgili kişi sisteme kayıt olduğunda müdürüne bilgilendirme e-postası gönderecek basit bir uygulamamız olduğunu düşünelim. Bu işlemleri tek bir sınıf içerisinde yerine getirebiliriz. Bu işlemi bu şekilde yaparsak bu prensibe ters düşmüş oluruz. Bu prensibe uymak için tüm bu işlemleri ayrı sınıflarda ele alamamız gerekmektedir. Her sınıfın sadece bir sorumluluğu olmalıdır. Örneğin, loglama işlemi için bir sınıfın, çalışanı veri tabanına kaydetmek için bir sınıf ve bilgilendirme e-postası için bir sınıf kullanılımalıdır.


## Open & Close Principle


- Nesneler ve varlıklar genişlemeye açık olmalı, ancak değişikliğe kapalı olmalıdır.Her yeni sınıf oluşturmak istediğimizde , bu oluşturmak istediğimiz sınıfı rahat bir şekilde oluşturmak isteriz.Zaten OOP genişletilebilirliği destekler.Lakin bu genişleme esnasında yaratılan sınıflarda modifikasyona gerek kalmayacak şekilde mimariyi kurmak gerekmektedir. 

- **Örnek1:**  Basit bir coffeshop uygulaması düşünelim, bu uygulamada bir coffe sınıfım ve coffee type'Larını tutacak enum var. Her yeni bir kahve türü geldiğinde enum'a kahve türünü ekliyoruz. Coffe sınıfında ise if-else yapılarıyla ilgli kahve türlerine göre içilen kahve birim fiyatına ve miktarına göre ücret hesabı yapıyor.Ama bu senaryodaki mimari bu prensibe ters düşmektedir. Bu prensibe uymak istersek soyut bir sınıfa methot tanımlayarak bu methodu her bir kahve için açacağımız sınıfta override ederek kullanmalıyız. Böylelikle her kahve için var olan sınıflarımda bir değişikliğe gitmemiş olacağım.Soyut sınıf yardımıyla kural koyarak alt sınıflarımızı değişeme kapalı tutmuş olduk. 

## Liskov Substitution Principle

- Alt sınıflarda oluşan nesneler üst sınıflardan oluşan nesneler ile yer değiştirilebilir olmalıdır. 

- **Örnek1:**  Karenin ve dikdörtgenin alanını hesaplayan basit bir uygulamamız olsun. Bir dikdörtgen sınıf oluşturarak bu sınıfa 2 member veriyoruz. Yüksekllik ve uzunluk, fakat kare geometrik şekili için bu ata sınıf çokta uygun olmamaktadır. Yani dikdörtgen sınıfından kalıtım alan bir kare sınıfından nesne oluşturmaya kalkarsak ata sınıfların mantığından ve amacından şaşmış oluyoruz ve bu prensibe ters düşmüş oluyoruz. Bu hatayı düzeltmek için dörtgen yapısnın ortak özelliklerini barındıracak bir sınıf oluşturulmalı ve her bir geometrik şekil için bir sınıf oluşturularak kendi alan hesaplamalarına sahip olduğundan emin olmalıyız.

## Interface Segration Principle

- Sınıflar ihtiyaçları olmayan özellikleri ve davranışları içeren interface'lerden implement edilmemelidir. 


- **Örnek1:**   IFlightlessBird ve IFlyingBird arayüzleri olsun, bu interfaceler Uçma ve Yürüyebilme yeteneklerine sahip olsun. İlgili interface'yi Tavuk ve Şahin sınıflarına implement ettiğimizi varsayalım. Bu implementation sonucunda Tavuk ve Şahin sınıfları ilgili yeteneklere kavuşur. Bu bağlamda sınıflar implemantation sonucunda ediğindiği yetenekleri karşılamamaktadır. Bu senaryoda Tavuk ve Şahin sınıfları gerekisiz bir davranış kazanmış ve bu Interface segration prensibine ters düşmüş durumdadır. Bu durumu düzeltmek için Uçabilen, Yürüyebilen kuşlar tarzında interface'ler açarak alt sınıfların gereksiz davranışlar kazanmasının önüne geçebiliriz.