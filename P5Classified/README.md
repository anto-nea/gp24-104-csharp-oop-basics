# P5Classified Project

This project demonstrates the use of inheritance to categorize various objects, items, and living beings into a class hierarchy.

## Class Hierarchy Diagram

```mermaid
classDiagram
    HandheldItem <|-- Weapon
    Weapon <|-- Sword
    Weapon <|-- Axe
    Weapon <|-- Shield
    Weapon <|-- Spear
    HandheldItem <|-- Pencil
    
    EdibleItem <|-- Fruit
    Fruit <|-- Banana
    Fruit <|-- Apple
    Fruit <|-- Pear
    EdibleItem <|-- Bread
    
    LivingBeing <|-- Tree
    LivingBeing <|-- Animal
    Animal <|-- Gorilla
    Animal <|-- Chimpanzee
    Animal <|-- Bird
    Bird <|-- Sparrow
    Bird <|-- Pigeon
    Bird <|-- Hawk
