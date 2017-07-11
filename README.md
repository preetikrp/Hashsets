# Hashsets
Used UnionWith and IntersectWith for the very first time.
1. Create an empty HashSet named `Showroom` that will contain strings.
1. Add four of your favorite car model names to the set.
1. Print to the console how many cars are in your show room.
1. Pick one of the items in your show room and add it to the set again.
1. Print your showroom again, and notice how there's still only one representation of that model in there.
1. Create another set named `UsedLot` and add two more car model strings to it.
1. Use the `UnionWith()` method on `Showroom` to add in the two models you added to `UsedLot`.
1. You've sold one of your cars. Remove it from the set with the `Remove()` method.

### Acquiring more cars

1. Now create another HashSet of cars in a variable `Junkyard`. Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. In the new set, add some different cars, but also add a few that are the same as in the `Showroom` set.
1. Use the `IntersectWith()` method to see which cars exist in both the show room and the junkyard.
1. Now you're ready to buy the cars in the junkyard. Use the `UnionWith()` method to combine the junkyard into your showroom.
1. Use the `Remove()` method to remove any cars that you acquired from the junkyard that you want in your showroom.
