
These setup instructions follow **Week 1**, Test-Driven Development with C# from Epicodus's [C# and .Net curriculum](https://www.learnhowtoprogram.com/c-and-net)

Setting up project from scratch

[MSTest Configuration and Setup](https://www.learnhowtoprogram.com/c-and-net/test-driven-development-with-c/mstest-configuration-and-setup)

After running `dotnet restore` and generating `obj` directories. In root directory:
    `touch .gitignore` and add to file `*/obj/`

[MSTest Writing and Running Tests](https://www.learnhowtoprogram.com/c-and-net/test-driven-development-with-c/mstest-writing-and-running-tests)

After setup, navigate to TDDcsharp.Tests and run `dotnet test`
Tests will pass, even without testing code, because it didn't receive any compiler errors.

add `*/bin/` to .gitignore. Generated after running dotnet test

[Our First Tests with MSTest](https://www.learnhowtoprogram.com/c-and-net/test-driven-development-with-c/our-first-tests-with-mstest)

Following "Red, Green, Refactor" Workflow, test for isCar was added in this order:

1. Identify the simplest possible behavior the program must exhibit"

```
my notes: "If string equals "car" return boolean true"
```

2. Write a coded test

ModelTests/CarDealership.cs
Note: Typo from previous commit. Change "public class CarDealership" to "public class CarDealershipTest
```
    [TestClass]
    public class CarDealershipTests
    {
        [TestMethod]
        public void isCar_StringEqualCar_True()
        {
            CarDealership testCarDealership = new CarDealership();
            Assert.AreEqual(true, testCarDealership.isCar("car"));
        }
    }
```


TDDcsharp/Models/CarDealership.cs 
(Nothing has changed. No code added yet)
```
    public class CarDealership
    {
        public bool isCar(string car)
        {
            return false;
        }
    }
```

3. Confirm Test Fails

Navigate to TDDcsharp.Tests and run `dotnet test`
test should fail - this is a good fail - Expected:<True>. Actual:<False>
a compiler error is not a fail.

4. Implement the behavior with the least amount of code possible

TDDcsharp/Models/CarDealership.cs 
```
    public class CarDealership
    {
        public bool isCar(string car)
        {
            return car == "car";
        }
    }
```

5. Confirm the test passes

Navigate to TDDchsarp.Tests and run `dotnet test`

6. Confirm previous tests still pass
    N/A no previous tests at the moment so moving on.

7. Check for refactoring
    Looks as DRY as it can be at the moment. Moving on.

8. Repeat
    There is probably more that we could use to define a car. Such as, "4 wheels", "steering wheel", "brakes"

1. Identify the simplest possible behavior the program must exhibit"

```
my notes: 
"If string equals "car" return boolean true"
"Other things makeup a car. If strings equals any of "car", "4 wheels", "steering wheel", "brakes" return boolean true
```
2. Write a coded test

ModelTests/CarDealership.cs
```
    [TestClass]
    public class CarDealershipTests
    {
        [TestMethod]
        public void isCar_StringEqualCar_True()
        {
            CarDealership testCarDealership = new CarDealership();
            Assert.AreEqual(true, testCarDealership.isCar("car"));
        }

        [TestMethod]
        public void isCar_StringNotEqualCarThings_False()
        {
            CarDealership testCarDealership = new CarDealership();
            Assert.AreEqual(false, testCarDealership.isCar("horse"));
        }
    }
```

3. Confirm test fails
    yes it does "car does not equal "horse"

4. Implement the behavior with the least amount of code possible

```
    public class CarDealership
    {
        public bool isCar(string car)
        {
            string[] whatIsCarArray = {"car", "4 wheels", "brakes", "steering wheel"};
            
            foreach (string carThing in whatIsCarArray)
            {
                if(car == carThing)
                {
                    return true;
                }
            }
            return false;
        }
    }
```

5. Confirm the test passes

Navigate to TDDchsarp.Tests and run `dotnet test`

6. Confirm previous tests still pass
    `isCar_StringEqualCar_True()`
    changed name to `isChar_StringEqualCarThing_True()`
    test too with other things that should be true like "4 wheels"
    run test again
    confirm passes

7. Check for refactoring
    Looks Dry but perhaps a way to loop over the first test so I don't have to add each thing at a time to test or repeat myself with lots of tests. Will leave as is for now since the array of things that define a car is fixed and confident if one string works then the rest will work

8. Repeat
    What else can go in my car dealership?