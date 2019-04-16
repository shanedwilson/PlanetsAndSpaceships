### PlanetsAndSpaceships

This was an exercise for NSS C#/.Net backend.

In the `Main` method, place the following code

    List<string> planetList = new List<string>(){"Mercury", "Mars"};

1. `Add()` Jupiter and Saturn at the end of the list.
2. Create another `List` that contains that last two planet of our solar system.
3. Combine the two lists by using `AddRange()`.
4. Use `Insert()` to add Earth, and Venus in the correct order.
5. Use `Add()` again to add Pluto to the end of the list.
6. Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.

## Iterating over planets

> Ref: [List of Solar System probes](https://en.wikipedia.org/wiki/List_of_Solar_System_probes)

1. Create a dictionary that will hold the name of a spacecraft
that we have launched, and a list of names of the planets that it has
visited. Remember that `List` is a Type just like native types (such as `string`, `int`, & `bool`) and your custom types (such as `Movie`, `Dog`, and `Food`). They can be passed to anything, like a dictionary, as a Type.
2. Iterate over your list of planets from above, and inside that loop,
iterate over the dictionary. Write to the console, for each planet,
which satellites have visited which planet.