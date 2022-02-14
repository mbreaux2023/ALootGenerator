# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

to let a person find a fun way to generate a bunch of loot.

**TODO: Complete this section**

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program can generate a list of random loot

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program receives a numeric input from the user and then outputs a list containing that amount of loot.

**TODO: Complete this section**

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
 List<string> weapons = new List<string>();
            weapons.Add("sword");
            weapons.Add("Mace");
            weapons.Add("Pistol");
            weapons.Add("bow");
            weapons.Add("dagger");
            weapons.Add("rifle");
            weapons.Add("revolver");
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
  Random generator = new Random();
            int index = generator.Next(0, weapons.Count);

            string randomWeapons = weapons[index];

            int index2 = generator.Next(0, elements.Count);

            string randomElements = elements[index2];

            int index3 = generator.Next(0, powers.Count);

            string randomPowers =powers[index3];
            
            return $"{randomWeapons} {randomElements} {randomPowers}";
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "weapons"

### 3b iv.

Describes what the data contained in the list represents in your program

The list represents all the possible weapons that can be generated.

**TODO: Write a sentence describing what is stored in the list**

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without a list, I would not be able to select a weapon by generating a random index. Instead, I would need to write 5 lines of code per each weapon I want to add If i wanted to add any.

Without a list, the complexity of my program would greatly increase unnecessarily because every time I want to add a weapon, I would need several more lines of add where as with this list I could just add in one line of code to the list making it more difficult to manage.

Without a list, it would be difficult but not impossible to have a selection of weapons since there would be no random index. If I wanted to add more possibilities it would make the process very redundant and not efficient. In order to manage

My list makes managing complexity a lot easier


## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static int GetValidInt(string prompt)
        {

            

            if (prompt == null)
            {
                // TODO: throw an exception
            }

            int userChoice;

            do
            {

                Console.Write(prompt);

                string input = Console.ReadLine();

                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("you did not enter a number");
                }
            
                else if (userChoice >= 4) 
                {
                    Console.Error.WriteLine("That is not a number 1-3");
                }

                else if (userChoice < 0)
                {
                    Console.Error.WriteLine("That is not a number 1-3");
                }
            }
            while (userChoice >= 4 || userChoice < 0); 

            return userChoice;

        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
int combos = GetValidInt("How many loot combinations would you like out of 3?");
```

### 3c iii. *

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program. *

   /// <summary>
            /// given a method prompt to show the user, this method reads user input and checks if the input is an integer and if it falls between one and three. If it is than the method returns the user's choice
            /// If the user does not input an integer then the program recognizes an error and prompts the user to try again.
            /// If the user inputs an integer but it does not fall between 1 and 3 then the program recognizes an error and prompts the user to try again.
            /// </summary>
            /// <param name="prompt"></param>
            /// This method prompts the user to select a number between one and three and then returns the users choice


### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

            // 1. Validate the prompt is a string
            // 2. Display the prompt
            // 3. read input from the user 
            // 4. If the user entered an invalid weapon, power, or element type,
            // - display an error message
            //  - go to step 2
            // 5. Otherwise, return the users input
## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call: 
GetValidInt(null);

**TODO: Complete this section**

Second call:
GetValidInt("Enter a number");

**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:

I am testing if the prompt the user has inputted is null. This will cause the body of the if statement to execute.
 
**TODO: Complete this section**

Condition(s) tested by the second call:

I am testing if the prompt the use has inputted is not null. THis will skip the body of the if statement.

**TODO: Complete this section**

### 3d iii.

Result of the first call:


The result of calling with a string that is null in an exception being thrown/
**TODO: Complete this section**

Result of the second call:

THe result of calling with a string that is validated*

**TODO: Complete this section**