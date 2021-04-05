
These setup instructions follow **Week 1**, Test-Driven Development with C# from Epicodus's [C# and .Net curriculum](https://www.learnhowtoprogram.com/c-and-net)

Setting up project from scratch

[MSTest Configuration and Setup](https://www.learnhowtoprogram.com/c-and-net/test-driven-development-with-c/mstest-configuration-and-setup)

After running `dotnet restore` and generating `obj` directories. In root directory:
    `touch .gitignore` and add to file `*/obj/`

[MSTest Writing and Running Tests](https://www.learnhowtoprogram.com/c-and-net/test-driven-development-with-c/mstest-writing-and-running-tests)

After setup, navigate to TDDcsharp.Tests and run `dotnet test`
Tests will pass, even without testing code, because it didn't receive any compiler errors.

add `*/bin/` to .gitignore. Generated after running dotnet test