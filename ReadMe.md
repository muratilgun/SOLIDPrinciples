**Single Responsibilty Principle**

- Bir s�n�f, method sadece bir i�i yapmal�d�r.

- Bir s�n�f�n de�i�mesi i�in sadece bir nedeni olmal�d�r. Yani bir s�n�f�n yanl�zca bir i�i olmal�d�r.

- �rne�in, i�e yeni ba�lam�� personelin �zl�k bilgilerinin sisteme kaydedilmesi, bu i�lemin loglar�n�n tutulmas� ve ilgili ki�i sisteme kay�t oldu�unda m�d�r�ne bilgilendirme e-postas� g�nderecek basit bir uygulamam�z oldu�unu d���nelim. Bu i�lemleri tek bir s�n�f i�erisinde yerine getirebiliriz. Bu i�lemi bu �ekilde yaparsak bu prensibe ters d��m�� oluruz. Bu prensibe uymak i�in t�m bu i�lemleri ayr� s�n�flarda ele alamam�z gerekmektedir. Her s�n�f�n sadece bir sorumlulu�u olmal�d�r. �rne�in, loglama i�lemi i�in bir s�n�f�n, �al��an� veri taban�na kaydetmek i�in bir s�n�f ve bilgilendirme e-postas� i�in bir s�n�f kullan�l�mal�d�r.


**Open & Close Principle**


- Nesneler ve varl�klar geni�lemeye a��k olmal�, ancak de�i�ikli�e kapal� olmal�d�r.Her yeni s�n�f olu�turmak istedi�imizde , bu olu�turmak istedi�imiz s�n�f� rahat bir �ekilde olu�turmak isteriz.Zaten OOP geni�letilebilirli�i destekler.Lakin bu geni�leme esnas�nda yarat�lan s�n�flarda modifikasyona gerek kalmayacak �ekilde mimariyi kurmak gerekmektedir. 

- �rne�in basit bir coffeshop uygulamas� d���nelim, bu uygulamada bir coffe s�n�f�m ve coffee type'Lar�n� tutacak enum var. Her yeni bir kahve t�r� geldi�inde enum'a kahve t�r�n� ekliyoruz. Coffe s�n�f�nda ise if-else yap�lar�yla ilgli kahve t�rlerine g�re i�ilen kahve birim fiyat�na ve miktar�na g�re �cret hesab� yap�yor.Ama bu senaryodaki mimari bu prensibe ters d��mektedir. Bu prensibe uymak istersek soyut bir s�n�fa methot tan�mlayarak bu methodu her bir kahve i�in a�aca��m�z s�n�fta override ederek kullanmal�y�z. B�ylelikle her kahve i�in var olan s�n�flar�mda bir de�i�ikli�e gitmemi� olaca��m.Soyut s�n�f yard�m�yla kural koyarak alt s�n�flar�m�z� de�i�eme kapal� tutmu� olduk. 