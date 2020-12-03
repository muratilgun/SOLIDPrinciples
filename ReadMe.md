**Single Responsibilty Principle**

- Bir sýnýf, method sadece bir iþi yapmalýdýr.

- Bir sýnýfýn deðiþmesi için sadece bir nedeni olmalýdýr. Yani bir sýnýfýn yanlýzca bir iþi olmalýdýr.

- Örneðin, iþe yeni baþlamýþ personelin özlük bilgilerinin sisteme kaydedilmesi, bu iþlemin loglarýnýn tutulmasý ve ilgili kiþi sisteme kayýt olduðunda müdürüne bilgilendirme e-postasý gönderecek basit bir uygulamamýz olduðunu düþünelim. Bu iþlemleri tek bir sýnýf içerisinde yerine getirebiliriz. Bu iþlemi bu þekilde yaparsak bu prensibe ters düþmüþ oluruz. Bu prensibe uymak için tüm bu iþlemleri ayrý sýnýflarda ele alamamýz gerekmektedir. Her sýnýfýn sadece bir sorumluluðu olmalýdýr. Örneðin, loglama iþlemi için bir sýnýfýn, çalýþaný veri tabanýna kaydetmek için bir sýnýf ve bilgilendirme e-postasý için bir sýnýf kullanýlýmalýdýr.