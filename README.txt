This is the README file for the WebBank application. It was created as a general ASP.NET 4 app with 
Visual Web Developer 2010 Express. It uses a simple code behind file to push the code off of the page
so that it can be tested with by the WebBankTest class library, which you'll also find nearby. WebBankTest
needs to have NUnit installed.

Download both the WebBank and WebBankTest applications. Unpack them and then have the WebBankTest reference 
the generated WebBank.dll file, which is tested by the WebBankTest application. WebBankTest also needs to have
a reference to the nunitframework.dll file.

With the two projects in place you can then build WebBank and then build WebBankTest. Then you can start NUnit Gui 
and point it to the WebBankTest.dll file to run the tests, which should all pass. Change the expected values of the tests
to see them fail. You need to rebuild the test project each time before you run it in NUnit.