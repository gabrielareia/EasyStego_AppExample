# EasyStego - Example application

## A simple application to show what EasyStego can do.
 
I created a very basic application, nothing fancy at all, but is enough to test the [EasyStego](https://github.com/gabrielareia/EasyStego) library.
 
EasyStego is a library to create steganography in images, using C#. You can hide images or texts inside your images. It's very fun. Check it out.
 
https://github.com/gabrielareia/EasyStego

## How to use

If you want to only use the application, you can download the executable from "Releases" on Github. Just extract the .zip to a folder and run the **"EasyStego_App.exe"**.

Now if you want to download the source code of the application and use it for testing the library and modify them in any way, do the following:

**Clone this repo to a folder**. **Clone the [EasyStego](https://github.com/gabrielareia/EasyStego) to another folder**.

Open the solution in **this repo** using Visual Studio, in the **solution explorer** right-click on the solution and add an **existing project**, select the **EasyStego.csproj** project in the [EasyStego](https://github.com/gabrielareia/EasyStego) repo you added to the other folder, after it is done you should have 2 projects inside your solution. Now add the new project (library) as a dependency to the first project (app), you can drag the **"EasyStego"** project and drop it on the **"Dependencies"** from the **"EasyStego_App"** project.

Now you should be all set, just hit F5 or ctrl+F5 and play around with it. 

Read the code first if you want to, and mess around with the code, now you have access to the app code and the library as well. 
If you find something interesting, or improve the code, don't be shy and send me a pull request.

Enjoy!
