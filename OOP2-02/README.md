# Task

Create a console application for a road simulation:​

### Vehicle
- abstract class
- contains properties brand and speed
- method `Drive()` method which prints "Vehicle {brand} is driving at the speed {speed}."​

### Car​
- Speed of every car is 10​
- Has a property `FuelLevel` which decreases by 1 each time it is driven​
- If the `FuelLevel` is 0, it doesn't drive and prints "Car {brand} is out of fuel"​
- Contains a `Refuel()` method which sets the fuel level to 2​

### Bicycle​
- Speed of each bycicle is 2​

### Road​
- Contains a list of Vehicles​
- Method to add a Vehicle​
- Method `Go()` which calls `Drive()` on all vehicles​

***

# Zadarak

Napravi konzolnu aplikaciju koja simulira cestu.

### Vehicle
- abstraktna klasa
- sadrži svojstva brand i speed
- metodu `Drive()` koja ispisuje "Vehicle {brand} is driving at the speed {speed}."​

### Car​
- Brzina svakog auta je 10​
- Sadrži svojstvo `FuelLevel` koje se smanjuje za 1 svaki put kada se auto vozi.
- Ako `FuelLevel` iznosi 0, auto ne može voziti u ispisuje "Car {brand} is out of fuel"​
- Sadrži metodu `Refuel()` koja postavlja `FuelLevel` na 2

### Bicycle​
- Brzina svake bickle je 2

### Road​
- Sadrži listu vozila
- Metodu za dodavanje vozila
- Metodu `Go()` koja poziva `Drive()` na svim vozilima

​​​
​

​