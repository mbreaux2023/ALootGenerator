# ALootGenerator

## Description 
The Loot Generator is used to generate a list of possible loot. It uses weapon types, power types, and elements to generate numerous possible outcomes

## Overview
The purpose of A Loot Generator is to provide entertainment to the user by creating unique loot. It accepts input from the user by letting them specify which weapon they want to generate. After accepting the number of weapons to generate, the program writes a list of random loot to the console.


## High level design
1. Prompts the user to select weapons
2. Loads a list of possible weapons 
3. Randomly selects a weapon out of weapon types
4. Prompts the user to select an element
5. Loads a list of possible elements
4. Randomly selects a element out of elements
5. Prompts the user to select a power type
6. Loads a list of possible powers
7. Randomly selects a power out of power types
8. Writes the randomly generated loot to the console
9. if more weapons need to be generated, go to step 1


### flowchart
![Connector Image](images/HighLevelFlowChart.jpg)

### Methods

To help manage the complexity of the program, I have written two helper methods:
- int GetValidInt(string prompt);
- string GenerateRandomName(List<string> weapons, List<string> powers, List<string>, elements);

#### int GetValidInt

Given a prompt to show the user, displays the prompt then reads input from the keyboard until the user enters a valid type. If the user enters an invalid type, this method displays an error message and prompts the user to try again.
![Connector Image](images/Display.jpg)

1. Validate the prompt is a string
2. Display the prompt
3. read input from the user 
4. If the user entered an invalid weapon, power, or element type,
    - display an error message
    - go to step 2
5. Otherwise, return the users input

#### string GenerateRandomLoot(List weapons, List powers, List elements)

Given a list of weapons, powers and elements, generate random loot using one entry from each list.
![Connector Image](images/Generator.jpg)

1. Create a random number generator
2. Generate a random number, first index, between 0 and weapons.Count
3. Generate a random number, midIndex, between 0 and powers.count
4. Generate a random number, lastIndex, between 0 and elements.count
5. Combine the weapon, power, and element together
    - weapons[firstIndex] + " " + power[midIndex] + " " + element[lastIndex];
6. Return the loot

