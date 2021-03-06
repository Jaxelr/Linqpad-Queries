<Query Kind="Expression" />

//Foreach for all
public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
{
	foreach (var item in items)
		action(item);
}