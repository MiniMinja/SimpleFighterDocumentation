# Standard
### Inherited Class

<br>

[back to Table of Contents](/Assets/Scripts/Character/TableOfContents.md)

<br>

## Description
This script acts as the central 'hub' for collecting user input. Uses a dictionary with LEFT, RIGHT, UP, DOWN as constants for looking up.

## Data

#### Constants

`string LEFT`  
`string RIGHT`  
`string UP`  
`string DOWN`  

#### Private

`Dictionary<string, bool> inputKeys`  

## Functions

#### Public

`bool Lookup(string key)`  

#### Private

`void Start()`  

`void Update()`  