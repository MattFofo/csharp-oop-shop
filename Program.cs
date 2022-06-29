using csharp_oop_shop;

Product myProduct = new Product("libro", 18.88, "un bel libro", 30);

Console.WriteLine(myProduct.nome);
Console.WriteLine(myProduct.prezzo);
Console.WriteLine(myProduct.descrizione);

Console.WriteLine(myProduct.GetBasicPrice());
Console.WriteLine(myProduct.GetPriceAfterIva());