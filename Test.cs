public class TestRepository 
{ 
	public IEnumerable<Person> Load() 
	{ 
		var persons = File .ReadAllLines("persons.csv") 
			.Select(l => l.Split(new[] {","}, StringSplitOptions.None)) 
			.Select(parts => new Person { 
				Id = int.Parse(parts[0]), 
				Name = parts[1], 
				Age = int.Parse(parts[2]) 
		});
		return persons; 
	} 
} 
