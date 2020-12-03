**Single Responsibilty Principle**

- Bir sýnýf, method sadece bir iþi yapmalýdýr.

- Bir sýnýfýn deðiþmesi için sadece bir nedeni olmalýdýr. Yani bir sýnýfýn yanlýzca bir iþi olmalýdýr.

- Örneðin, iþe yeni baþlamýþ personelin özlük bilgilerinin sisteme kaydedilmesi, bu iþlemin loglarýnýn tutulmasý ve ilgili kiþi sisteme kayýt olduðunda müdürüne bilgilendirme e-postasý gönderecek basit bir uygulamamýz olduðunu düþünelim. Bu iþlemleri tek bir sýnýf içerisinde yerine getirebiliriz. Bu iþlemi bu þekilde yaparsak bu prensibe ters düþmüþ oluruz. Bu prensibe uymak için tüm bu iþlemleri ayrý sýnýflarda ele alamamýz gerekmektedir. Her sýnýfýn sadece bir sorumluluðu olmalýdýr. Örneðin, loglama iþlemi için bir sýnýfýn, çalýþaný veri tabanýna kaydetmek için bir sýnýf ve bilgilendirme e-postasý için bir sýnýf kullanýlýmalýdýr.


**Open & Close Principle**


- Nesneler ve varlýklar geniþlemeye açýk olmalý, ancak deðiþikliðe kapalý olmalýdýr.Her yeni sýnýf oluþturmak istediðimizde , bu oluþturmak istediðimiz sýnýfý rahat bir þekilde oluþturmak isteriz.Zaten OOP geniþletilebilirliði destekler.Lakin bu geniþleme esnasýnda yaratýlan sýnýflarda modifikasyona gerek kalmayacak þekilde mimariyi kurmak gerekmektedir. 

- Örneðin basit bir coffeshop uygulamasý düþünelim, bu uygulamada bir coffe sýnýfým ve coffee type'Larýný tutacak enum var. Her yeni bir kahve türü geldiðinde enum'a kahve türünü ekliyoruz. Coffe sýnýfýnda ise if-else yapýlarýyla ilgli kahve türlerine göre içilen kahve birim fiyatýna ve miktarýna göre ücret hesabý yapýyor.Ama bu senaryodaki mimari bu prensibe ters düþmektedir. Bu prensibe uymak istersek soyut bir sýnýfa methot tanýmlayarak bu methodu her bir kahve için açacaðýmýz sýnýfta override ederek kullanmalýyýz. Böylelikle her kahve için var olan sýnýflarýmda bir deðiþikliðe gitmemiþ olacaðým.Soyut sýnýf yardýmýyla kural koyarak alt sýnýflarýmýzý deðiþeme kapalý tutmuþ olduk. 