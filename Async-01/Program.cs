
Console.WriteLine(DateTime.Now.ToLongTimeString());
Task<string> task1 = DownloadDataAsync1();
Task<string> task2 = DownloadDataAsync2();

await Task.WhenAll(task1, task2);

Console.WriteLine($"Tasks completed! Data: {task1.Result}, {task2.Result}");
Console.WriteLine(DateTime.Now.ToLongTimeString());

static async Task<string> DownloadDataAsync1()
{
    await Task.Delay(6000);
    return "data1";
}

static async Task<string> DownloadDataAsync2()
{
    await Task.Delay(6000);
    return "data2";
}
