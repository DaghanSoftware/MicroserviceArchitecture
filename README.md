# MicroserviceArchitecture
.Net 7 ile Microservice Mimarisi

![image](https://github.com/DaghanSoftware/MicroserviceArchitecture/assets/64596085/4e7a6b72-2dc7-449d-9de7-7f9e337816eb)


Microservices :

Catalog Microservice: Kurslarımız ile ilgili bilgilerin tutulmasından ve sunulmasından sorumlu olacak mikroservisimiz.
MongoDb (Veritabanı)
One-To-Many/One-To-One ilişki
MongoDb

Basket Microservice: Sepet işlemlerinden sorumlu olacak mikroservisimiz.
RedisDB(Veritabanı)

Discount Microservice: Kullanıcıya tanımlanacak indirim kuponlarından sorumlu olacak mikroservisimiz.
PostgreSQL(Veritabanı)

Order Microservice: Sipariş işlemlerinden sorumlu olacak mikroservisimiz.
Bu mikroservisimizde Domain Driven Design yaklaşımını kullanarak geliştiriyor olacağız.
Bu mikroservisimizde CQRS tasarım kalıbını uygulamak için MediatR kütüphanesini kullanıyor olacağız.
Sql Server(Veritabanı)
Domain Driven Design
CQRS (MediatR Libarary)

FakePayment Microservice
Ödeme işlemlerinden sorumlu olacak mikroservisimiz.

IdentityServer Microservice
Sql Server(Veritabanı)
Kullanıcı dataların tutulmasından,token ve refreshtoken üretilmesinden sorumlu olacak microservisimiz.

PhotoStock Microservice
Kurs fotograflarının tutulmasından ve sunulmasından sorumlu olacak mikroservisimiz.

API Gateway
Ocelot Library
Message Broker
Mesaj kuyruk sistemi olarak RabbitMQ kullanıyor olacağız.
RabbitMQ ile haberleşmek için MassTransit kütüphanesini kullanıyor olacağız.
RabbitMQ (MassTransit Library)
Identity Server
Token / RefreshToken üretmek
Access Token ile microservice'lerimizi korumak
OAuth 2.0 / OpenID Connect protokollerine uygun yapı inşa etmek

Asp.Net Core MVC Microservice
Microservice'lerden almış olduğu dataları kullanıcıya gösterecek ve kullanıcı ile etkileşime geçmekten sorumlu olacak UI mikroservisimiz

Öğrenecekleriniz
.Net 5.0 ile Microservice Architecture
Asynchronous and Aynchronous between Microservices
API Gateway ( Ocelot Libarary)
RabbitMQ
Docker & Docker Compose
IdentityServer4
AccessToken/RefreshToken
Domain Driven Design
CQRS Pattern
PostgreSQL
MongoDB
SqlServer
Kurs gereksinimleri veya ön koşulları var mı?
C# bilgisi
AspNet Core MVC bilgisi
AspNet Core MVC API bilgisi
IdentityServer Library bilgisi
RabbitMQ bilgisi
Identity API bilgisi
JWT bilgisi




Microservices:

Catalog Microservice: Our microservice responsible for storing and presenting information about our courses. MongoDB (Database) One-To-Many/One-To-One relationship in MongoDB.

Basket Microservice: Our microservice responsible for basket operations. RedisDB (Database).

Discount Microservice: Our microservice responsible for managing discount coupons assigned to users. PostgreSQL (Database).

Order Microservice: Our microservice responsible for order operations. We will develop this microservice using the Domain Driven Design approach. We will use the MediatR library to implement the CQRS design pattern in this microservice. Sql Server (Database), Domain Driven Design, CQRS (MediatR Library).

FakePayment Microservice: Our microservice responsible for payment operations.

IdentityServer Microservice: Sql Server (Database). Our microservice responsible for storing user data, generating tokens, and refresh tokens.

PhotoStock Microservice: Our microservice responsible for storing and presenting course photos.

API Gateway: Ocelot Library, Message Broker, RabbitMQ will be used as a message queue system. We will use the MassTransit library to communicate with RabbitMQ. RabbitMQ (MassTransit Library), Identity Server Token/RefreshToken generation, protecting our microservices with Access Token, building a structure compliant with OAuth 2.0/OpenID Connect protocols.

Asp.Net Core MVC Microservice: Our UI microservice responsible for displaying data received from microservices and interacting with the user.

You will learn:

Microservice Architecture with .Net 5.0
Asynchronous and Synchronous communication between Microservices
API Gateway (Ocelot Library)
RabbitMQ
Docker & Docker Compose
IdentityServer4 AccessToken/RefreshToken
Domain Driven Design
CQRS Pattern
PostgreSQL
MongoDB
SqlServer
Prerequisites:

Knowledge of C#
Knowledge of AspNet Core MVC
Knowledge of AspNet Core MVC API
Knowledge of IdentityServer Library
Knowledge of RabbitMQ
Knowledge of Identity API
Knowledge of JWT


