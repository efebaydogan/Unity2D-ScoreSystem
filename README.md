# Score System in Unity2D - English

With this repository, you can learn "How to Make Score System" in Unity 2D.


## Frequently asked Questions

#### What are variables for?

public TextMeshProUGUI scoreText; - To access the text object we created in Unity.

public int score = 0; - To change the score.

#### What is meaning OnTriggerEnter2D?

It is a function that runs when an object starts to pass through another object.

ATTENTION : Don't forget to add the ScoreSystem code to your character.

ATTENTION : For the application to work correctly, the isTrigger in the collider of the object you will collect points from must be active.

ATTENTION : The tag of the object you will collect points for should be "star" (I made it a star because my object is a star)

## What you need to do in Unity

- You need to create a text object. To do this, you need to right-click on the hierarchy section and select UI > Text/TextMeshPro.

- Then, we drag the text object we created to the "ScoreText" section in the ScoreSystem code we created before.


## Author

- Created by Efe Baydoğan.

  ----------------------------------------------------------------------------------------------------

  # Unity2D'de Skor Sistemi - Türkçe

Bu depo ile Unity 2D'de "Skor Sistemi Nasıl Yapılır" öğrenebilirsiniz.


## Sık Sorulan Sorular

#### Değişkenler ne içindir?

public TextMeshProUGUI scoreText; - Unity'de oluşturduğumuz metin nesnesine erişmek için.

public int score = 0; - Skoru değiştirmek için.

#### OOnTriggerEnter2D ne anlama geliyor?

Bir nesne başka bir nesnenin içinden geçmeye başladığında çalışan bir fonksiyondur.

DİKKAT : ScoreSystem kodunu karakterinize eklemeyi unutmayın.

DİKKAT : Uygulamanın doğru çalışabilmesi için puan toplayacağınız nesnenin collider'ındaki isTrigger aktif olmalıdır.

DİKKAT : Puan toplayacağınız objenin etiketi "star" olmalı.(Benim objem yıldız olduğu için yıldız yaptım.)

## Unity'de yapmanız gerekenler

- Bir metin nesnesi oluşturmanız gerekir. Bunu yapmak için hiyerarşi bölümüne sağ tıklayıp UI > Text/TextMeshPro'yu seçmeniz gerekiyor.

- Ardından oluşturduğumuz metin nesnesini daha önce oluşturduğumuz ScoreSystem kodundaki "ScoreText" bölümüne sürüklüyoruz.

## Yazar

- Efe Baydoğan tarafından oluşturuldu.
