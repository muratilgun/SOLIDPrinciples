**Single Responsibilty Principle**

- Bir s�n�f, method sadece bir i�i yapmal�d�r.

- Bir s�n�f�n de�i�mesi i�in sadece bir nedeni olmal�d�r. Yani bir s�n�f�n yanl�zca bir i�i olmal�d�r.

- �rne�in, i�e yeni ba�lam�� personelin �zl�k bilgilerinin sisteme kaydedilmesi, bu i�lemin loglar�n�n tutulmas� ve ilgili ki�i sisteme kay�t oldu�unda m�d�r�ne bilgilendirme e-postas� g�nderecek basit bir uygulamam�z oldu�unu d���nelim. Bu i�lemleri tek bir s�n�f i�erisinde yerine getirebiliriz. Bu i�lemi bu �ekilde yaparsak bu prensibe ters d��m�� oluruz. Bu prensibe uymak i�in t�m bu i�lemleri ayr� s�n�flarda ele alamam�z gerekmektedir. Her s�n�f�n sadece bir sorumlulu�u olmal�d�r. �rne�in, loglama i�lemi i�in bir s�n�f�n, �al��an� veri taban�na kaydetmek i�in bir s�n�f ve bilgilendirme e-postas� i�in bir s�n�f kullan�l�mal�d�r.