# Different Types of Paradigms
- Procedural
- Object Oriented
- Functional
- Logical

## Procedural (Imperative)
Think C.

## Object Oriented
OOP goes further and defines the set of procedures that can be applied to a particular data package. The whole is called an object.

Think C++/Java/C#.

Benefits:
- reduce complexity
- reuse code

## Functional
A program is a mathematical function. It maps a list of inputs to a list of outputs. Think Set Theory.

In this paradigm, commands aren't used and memory state isn't followed.

Following program written in F#:\
Given imperative program
```fs
let add2 a = a + 2
let multiply3 a = a * 3
let addAndMultiply a = 
    let add = add2 a
    let product = multiply3 add
    product
```
convert to functional
```fs
let add2 a = a + 2
let multiply3 a = a * 3
let addAndMultiply = add2 >> multiply3
```

The primary goal of functional languages is to minimize the use of mutable state.

## Logical
THink SWI-Prolog
Logic paradigm uses a set of facts and a set of rules to answer questions.

## Declaritive = Procedural + Logical

> A well known slogan (R. Kowalski):
> - __Algorithm = Logic + Control__
> - Logic: What must be done
> - Control: How the desired solution is found

Imperative programming must consider both components. Logic only needs to consider the logic.

# Examples:
## Horizontal and Vertical Line Segments:
There are three types of line segments, horizontal, vertical, or oblique(diagonal).

Solve in OOP, Functional, Logic: