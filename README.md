# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a class property before it has been assigned a value.  Uninitialized properties can lead to unexpected behavior or exceptions, depending on the context. The `bug.cs` file shows the problematic code, while `bugSolution.cs` provides a corrected version.

## Problem
The issue stems from accessing `MyProperty` in the `MyMethod` function before it's been given a value.  In C#, class properties have default values (0 for integers, null for strings etc.), but this might not always be what's intended. If you access the property before initialization, you might inadvertently use this default value, leading to incorrect calculations or unexpected results.

## Solution
The solution involves ensuring that the property is initialized before it is accessed. This can be done either in the constructor or by explicitly assigning it a value before using it.