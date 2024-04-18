using Tasks.Models;

Console.WriteLine("going to prepare our breakfast");

await PrepareEgg();
Console.WriteLine("Egg is ready");

await PrepareTea();
Console.WriteLine("Egg is ready");

await BoilCheese();
Console.WriteLine("Egg is chesse ");

Task.Delay(6000).Wait();

Console.WriteLine("our beatifull food is ready!!!!!!!!!!!!!!!!!!!!!");


async Task<Egg> PrepareEgg() =>
    await Task.Run<Egg>(() =>
    {
        Task.Delay(5000).Wait();
        Console.WriteLine("take 10 Eggs from freezer");
        Thread.Sleep(1000);
        Console.WriteLine("put eggs in plate");
        Thread.Sleep(2000);

        Console.WriteLine("warming eggs");

        return new Egg();
    });

async Task<Tea> PrepareTea() => await Task.Run<Tea>(() =>
{
    {
        Console.WriteLine("spilling  a water in cupe");
        Thread.Sleep(1000);
        Console.WriteLine("waring tea ");
        Thread.Sleep(3000);

        return new Tea();
    }
});

async Task<Cheese> BoilCheese() => await Task.Run(() =>
{
    Console.WriteLine("spilling  a water in cupe with cheese");
    Thread.Sleep(1000);
    Console.WriteLine("warming cheese cube ");
    Thread.Sleep(5000);

    return new Cheese();
});

async Task<int> test()
{
    await PrepareEgg();
    return 2;
}