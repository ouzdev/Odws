# Odws Note App

### Back-end tarafında kullanılan teknolojiler
* .NET 6.0
* Entity Framework Core
* AutoMapper
* Serilog & Seq
* PostgreSQL
* JWT (Json Web Token)
* Swagger 

## Proje Roadmap

Kişisel hayatta önemli anları not etmek için tasarlanan ve güncel teknolojileri içerisinde barındıran bir uygulama olup bu projeyi geliştirme amacı olarak hem güncel teknolojileri deneyimleme ve ortaya kullanışlı bir ürün çıkarmak amaçlanmaktadır. Uygulama temel olarak 3 kısımdan oluşmaktadır. 

Bunlar;

* Back-End
* Front-End
* Deployment

### Back-End

Back-End tarafında uygulama için .NET 6.0 çatısı, Minimal API ve çeşitli güncel teknolojiler kullanılmıştır. Logging, Authorization & Authentication, Access Database, Validation, Performans ve Test gibi daha bir çok konu göz önünde bulundurularak kodlanmaya devam edilmektedir. Kısacası bu kısımda bir Web API projesinin bünyesinde bulunması gereken çoğu yaklaşım uygulanmaya çalışılmaktadır. Back-end kısmını geliştirirken desing patterns ve best-practices gibi yaklaşımlar benimsenecektir.

### Front-End

Back-End kısmına paralel olarak Front-End tarafında React kullanlacaktır. Kullanıcı giriş, kayıt olma arayüzleri ve notların listelendiği bir arayüz tasarlanıp kodlanacaktır.

### Deployment

Uygulamayı production ortamına aktarırken Docker, Jenkins CI/CD pipeline, Aws, Firebase gibi platformlar ve toollar kullanılacaktır. 
