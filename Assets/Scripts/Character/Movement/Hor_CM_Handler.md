# Hor_CM_Handler    
### MonoBehaviour

[back to Table of Contents](/Assets/Scripts/Character/TableOfContents.md)
<br>

## Description
This script controls the horizontal movement of the player.


## Data

### Public 

`float movePower`  
the power multiplier when applying a force to the player's rigidbody.

### Private

`InputLookup lookup`   
reference to the [InputLookup](/Assets/Scripts/Character/Movement/InputLookup.md) script.

`Rigidbody2D rb`  
reference to the Rididbody component.

## Functions

### Public 

`void Move()`  
applies a force in the horizontal direction, multiplied by the `movePower` variable.

### Private

`void Start()`  
initializes all the variables of this script.

`void FixedUpdate()`  
looks up the input of the [InputLookup](/Assets/Scripts/Character/Movement/InputLookup.md) reference (`lookup`) and calls `Move()` function.