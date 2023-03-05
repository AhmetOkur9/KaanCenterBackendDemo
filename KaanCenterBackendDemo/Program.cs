using KaanCenterBackendDemo.Abstract;
using KaanCenterBackendDemo.Adapters;
using KaanCenterBackendDemo.Concrete;
using KaanCenterBackendDemo.Entities;

// ---------Customer:If you want to connect to Mernis:Replace line 7 with 8
//CustomerControl customerManager = new CustomerManger(new MernisServiceAdapter());
CustomerControl customerManager = new CustomerManger(new CustomerCheckManager());
customerManager.Save(new Customer {Id=1, Name = "Ahmet Kaan", Surname = "Okur", NationalId = "111111111", DateOfBirth = new DateTime(2002, 8, 13) ,DateOfRegistration=new DateTime(2023,3,5) });

Customer customer1 = new Customer {Id=2,Name="Erol",Surname="Okur",DateOfBirth = new DateTime(2010,2,2),DateOfRegistration=new DateTime(2023,2,1),NationalId="222222222" };
CustomerControl customerManager1 = new CustomerManger(new CustomerCheckManager());
customerManager1.Save(customer1);

//----------Product:
Product product1 = new Product();
product1.Id = 1;
product1.Name = "Elden Ring";
product1.Price= 100;

Product product2 = new Product();
product2.Id = 2;
product2.Name = "Cyberpunk 2077";
product2.Price = 120;

Product product3 = new Product();
product3.Id = 3;
product3.Name = "Mortal Kombat 11";
product3.Price = 80;

ProductService productService = new ProductService();
productService.Sell(product1,customer1);

//----------- Offer:
Offer offer1 = new Offer();
offer1.OfferID = 1;
offer1.OfferName = "Welcome February";
OfferService offerService= new OfferService();
offerService.Add(offer1, product1, customer1);

