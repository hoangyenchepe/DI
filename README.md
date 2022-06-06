# Dependency Injection in ASP.NET Core.

Learn by Steve Gordon course

![image](https://user-images.githubusercontent.com/22677953/170874433-82c8c20f-3d46-4f36-8554-719741d6ab80.png)

![image](https://user-images.githubusercontent.com/22677953/170875773-cff0e131-592c-45ab-ac92-91f472d64149.png)

![image](https://user-images.githubusercontent.com/22677953/170875832-6fef20c7-5563-43ac-9e01-b088293ce715.png)




## **1. Service Lifetimes**

Transient: Created each time they are requested.
![image](https://user-images.githubusercontent.com/22677953/170877794-da748aaf-2316-4d2d-a9a6-2cd8158d8930.png)


* Not required to be thread-safe 

* Potentially less efficient 

* Easiest to reason about 

Singleton: Created once for the lifetime of the application.
![image](https://user-images.githubusercontent.com/22677953/170877824-507f8391-373c-476f-8a96-ca08dc292922.png)


* Generally more performant

     Allocates less objects

     Reduces load on GC

* Must be thread-safe

* Suited to functional stateless services

* Consider frequency of use vs. memory consumption

Scoped: Created once per request.
![image](https://user-images.githubusercontent.com/22677953/170877853-1d01e898-99e8-49ee-9201-2ba270747093.png)


**A scoped service should not depend on a transient service**

**A Singleton service should not depend on a transient service and scoped service**
![image](https://user-images.githubusercontent.com/22677953/170877957-025af231-5738-4240-9d69-e7a315684292.png)

