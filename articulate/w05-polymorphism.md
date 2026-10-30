

# Polymorphism

## Meaning

Polymorphism is when code can have different behaviors depending on the context. A child class can change ("morph") method behavior in an inherited class.

## Benefit

Allows your code to scale much better. Base classes provide a rough draft/template. If you need more specificity or another "object" you can just create another derived class, instead of having to mess with what is already established. Allows for flexibility.

## Application

Let's say you are running a Dungeons and Dragons game for your friends and you build a program to track their encounters. You create a base class, Enemy, which has things like hit points and behavior and species or loot. And then the derived classes are more specific, and can populate the base methods with what is relevant. 

## Example

    public override string GetSaveString()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_IsComplete}";

    }
