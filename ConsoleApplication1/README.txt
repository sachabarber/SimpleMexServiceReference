++++++++++++++++++++++++++
WHAT IS THIS
++++++++++++++++++++++++++

This is a minimal WCF self hosted (console app) that exposes metadata. I hate service references and always prefer to use the shared Dll route, 
but for those times when you simply have to do it using a service reference, mex is the way to go. I forget this all the time, so decided
to add a simple demo here

It also shows a client that has used the mex endpoint to create a new service reference.


++++++++++++++++++++++++++
HOW TO RUN IT
++++++++++++++++++++++++++

1. Open command line in Admin mode, and run the ConsoleApplication1\bin\debug\ConsoleApplication1.exe. Ensure all is ok
   by opening a browser window and entering http://localhost:8000/SimpleService
2. From within Visual studio use the client, and add new service reference, where you should enter the url 
   "http://localhost:8000/SimpleService" which exposes the metadata
3. Use the generated proxy to your hearts content