# Overview 
A bookstore wants to grow their market size and decides to use ecommerce as a means, they want to build a
website for their customers to browse a variety of books, buy it online and ship it via different delivery
services. The store coordinates with delivery vendors of motorbike, train and aircraft for their service. Thedelivery cost varies based on the delivery service and season, i.e. it is cheaper during summer due to low demand however more expensive during school time due to high demand.
# Frameworks 
* API use .NET core 2.2
* Font-End use Angular 4.0
# How to start
* API: Open AugenBookStore.sln, then F5 to run API
* Font-End: 
`npm install`
`npm run start`

# Constructors 
* Three layers: Controller, Services, Repositories
* Patterns:
** Repository: in future, if change date source, the service layer will not care and always works well.
** Dependence Injection: reduce dependence between classes, easier init a object that don't care dependence of them.
** Strategy: the calculate cost base on service type and season, the cost will have different behaviors. To solve this, we apply Strategy Pattern.

# Time summary:
* Read requiment: 1 hour
* Overview and decide patterns, structors whick need to apply this project: 2 hours
* Coding API: 5 hours (including tests)
* Coding Font-End: 3 hours (including tests)
* Building and testing 1 hour
* ```Grant total: 12 hours```
