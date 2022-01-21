using Foods;
Foods.type foodType;
Foods.ingredients ingredients;
Foods.seasoning seasoning;

Console.Clear();
Console.Write(@" --- Food Types ---
- soup -
- stew -
- gumbo -
Please choose a Food type: ");

foodType = (Foods.type)Enum.Parse(typeof(Foods.type), Console.ReadLine());

Console.Write(@" --- Ingredients ---
- mushrooms -
- chicken -
- carrots -
- potatoes -
Now choose an ingredient: ");

ingredients = (Foods.ingredients)Enum.Parse(typeof(Foods.ingredients), Console.ReadLine());

Console.Write(@" --- Seasoning ---
- Spicy -
- Salty -
- Sweet -
Finally, choose a seasoning: ");

seasoning = (Foods.seasoning)Enum.Parse(typeof(Foods.seasoning), Console.ReadLine());

(Foods.type, Foods.ingredients, Foods.seasoning) soup = (foodType, Foods.ingredients.chicken, Foods.seasoning.salty);

Console.WriteLine($"You chose a {seasoning} {foodType} with {ingredients}. Great choice!");
Console.WriteLine($"Tuple: {soup}");