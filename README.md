# **Takım İsmi**

Takım Unity U2

# Ürün İle İlgili Bilgiler

## Takım Elemanları
- Ömer Hızlı: Scrum Master / Product Owner / Developer
- F. Taha Türkarslan: 3D Artist
- Emirhan Şahin: Developer
- Aygül Çınar: Aktif Olmayan Üye
- Nida Çolak: Aktif Olmayan Üye

## Ürün İsmi

--Sessiz Otel--

## Product Backlog URL

[Sessiz Otel Trello](https://trello.com/b/N5wxWRjZ/sessiz-otel)

## Ürün Açıklaması

Oyun, karakterimizin kendisini bir anda yalnız başına kaldığı gizemli bir otelde başlıyor. Ancak otelin sessizliği sizi derinden etkileyecek. Karakterimizin zihinsel sıkıntıları ve korkuları, oyun boyunca sizi rahatsız eden, sizi kendi gerçeklik algınızı sorgulamaya yönlendiren anlarla şekilleniyor.

## Ürün Özellikleri

- Gerilim Dolu Bir Hikaye
- Atmosferik Ortamlar
- Zorlu Bulmacalar
- Psikolojik Gerilim Unsurları

## Hedef Kitle

- Korku Severler
- Bilgisayar Oyuncuları 

## Juriye Not

3 Kişi olduğumuz birimizin işleri sebebiyle birimizin sınavları nedeniyle sürecimiz biraz zor geçiyor.

---

# Sprint 1

- **Sprint içinde tamamlanması tahmin edilen puan**: 100 Puan


- **Puan tamamlama mantığı**: Toplamda proje boyunca tamamlanması gereken 400 puanlık backlog bulunmaktadır. 3 sprint'e bölündüğünde ilk sprint'in en azından 100 ile başlaması gerektiğine karar verildi.


- **Daily Scrum**: Daily Scrum toplantılarını Discord üzerinden sesli bir şekilde yapılmasına karar verilmiştir. Daily Scrum toplantısı örneği png: [Sprint 1 Daily Scrum Chats](https://github.com/emirhansahintr/Bootcamp2023-U2Takimi/blob/main/ProjectManagement/Sprint1/Scrum1.png)

- **Sprint board update**: Sprint board screenshotları: 
![Backlog 1](https://github.com/emirhansahintr/Bootcamp2023-U2Takimi/blob/main/ProjectManagement/Sprint1/Sprint1.png) 


- **Ürün Durumu**: Ekran görüntüleri:
  ![Screenshot 1](https://github.com/emirhansahintr/Bootcamp2023-U2Takimi/blob/main/ProjectManagement/Sprint1/Unity1.png)
  ![Screenshot 2](https://github.com/emirhansahintr/Bootcamp2023-U2Takimi/blob/main/ProjectManagement/Sprint1/Animation1.gif)
  ![Screenshot 3](https://github.com/emirhansahintr/Bootcamp2023-U2Takimi/blob/main/ProjectManagement/Sprint1/Models1.png)
  Karakter Kontrolcüsü:
```csharp
public CharacterController controller;

    public float speed = 12f;
    public float sprint = 18f;
    public float walkspeed = 12f;
    public float slowspeed = 3f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;


    Vector3 velocity;
    public bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        //Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        //Run
        if (Input.GetKey(KeyCode.LeftShift) && isGrounded && speed == 12f)
        {
            speed = sprint;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = walkspeed;
        }
        //Slow
        if (Input.GetKey(KeyCode.LeftControl) && isGrounded && speed == 12f)
        {
            speed = slowspeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed = walkspeed;
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
```
  
- **Sprint Review:** Karakter kontrollerine karar verilmiş, bir kısmı kodlanmış, otelin genel teması belirlenmiş, animasyonlara başlanmış ve eksikler değerlendirilmiştir. Sprint Review Katılımcıları: Talha Türkarslan, Ömer Hızlı ve Emirhan Şahin
  
- **Sprint Retrospective:**
  - Takım üyelerinin gelecek sprintlerde aktif olması gerektiğine vurgu yapılmıştır.
  - Roller belirlendi.
  - Daily scrumları olabildiğince sesli şekilde yapılmaya karar verildi.
---

# Sprint 2

- **Sprint içinde tamamlanması tahmin edilen puan**: 150 Puan


- **Puan tamamlama mantığı**: Toplamda proje boyunca tamamlanması gereken 400 puanlık backlog bulunmaktadır. 3 sprint'e bölündüğünde ikinci sprint'in  150 puan olması gerektiğine karar verildi.

- **Daily Scrum**: Daily Scrum toplantılarını Discord üzerinden sesli bir şekilde devam edilmesine karar verilmiştir.

 Daily Scrum toplantısı örneği png:  [Sprint 2 Daily Scrum Chats](https://github.com/emirhansahintr/Bootcamp2023-U2Takimi/blob/main/ProjectManagement/Sprint1/daily2.png)




- **Sprint board update**: Sprint board screenshotları: 
  ![trello](https://github.com/emirhansahintr/Bootcamp2023-U2Takimi/assets/129771621/e5b74dae-23e0-4b3b-8018-95579e6b7339)

- **Ürün Durumu**: Ekran görüntüleri:

- ![fener](https://github.com/emirhansahintr/Bootcamp2023-U2Takimi/assets/129771621/551bedce-1c1e-45f2-a1fa-20890049e147)

- ![texture](https://github.com/emirhansahintr/Bootcamp2023-U2Takimi/assets/129771621/deee3930-5db5-4c01-8ff6-080a2d05144d)




 
- **Sprint Review:** Karakter etkileşim kodu yazıldı , gerekli 3D modellemeler yapıldı, yeni animasyonlara başlanmış ve eksikler değerlendirilmiştir. Sprint Review Katılımcıları: Talha Türkarslan, Ömer Hızlı ve Emirhan Şahin
  
- **Sprint Retrospective:**
  - Takım üyelerinin gelecek sprintlerde daha aktif olması gerektiğine vurgu yapılmıştır.
 
